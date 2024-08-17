using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Run_Partner.Data;
using Run_Partner.DTOs;
using Run_Partner.Interfaces;
using Run_Partner.Models;

namespace Run_Partner.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	[Authorize]
	public class UsersController(IUserRepository userRepository) : ControllerBase
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

		
	}
}
