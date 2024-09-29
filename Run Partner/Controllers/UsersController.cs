using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Run_Partner.Data;
using Run_Partner.DTOs;
using Run_Partner.Interfaces;
using Run_Partner.Models;
using System.Security.Claims;

namespace Run_Partner.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	[Authorize]
	public class UsersController(IUserRepository userRepository, IMapper mapper) : ControllerBase
	{
		
		[HttpGet]
		[Route("GetAll")]
		public async Task<ActionResult<IEnumerable<MemberDto>>> GetUsers() 
		{
			var users = await userRepository.GetMembersAsync();

			return Ok(users);

		}

		[HttpGet]
		[Route("{username}")]

		public async Task<ActionResult<MemberDto>> GetUser(string username) 
		{
			var user = await userRepository.GetMemberAsync(username);

			if (user == null) return NotFound(); 

			return user;
		}

		[HttpPut]
		public async Task<ActionResult> UpdateUser(MemberUpdateDto memberUpdateDto)
		{
			var username = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;

			if (username == null) return BadRequest("No UserName found in token");

			var user = await userRepository.GetUserByUserNameAsync(username);

			if (user == null) return BadRequest("Could not find user");

			mapper.Map(memberUpdateDto, user);

			if (await userRepository.SaveAllAsync())
			{
				return NoContent();

			}

			return BadRequest("Failed to update");

		}
	}
}
