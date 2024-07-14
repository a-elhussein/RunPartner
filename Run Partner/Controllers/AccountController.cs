using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Run_Partner.Data;
using Run_Partner.DTOs;
using Run_Partner.Models;
using System.Security.Cryptography;
using System.Text;

namespace Run_Partner.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class AccountController(RunPartnerDbContext dbContext) : ControllerBase
	{
		private readonly RunPartnerDbContext dbContext = dbContext;

		// /api/account/Register
		[HttpPost]
		[Route("Register")]
		public async Task<IActionResult> Register([FromBody] RegisterDto registerDto) 
		{
			if (await UserExistCheck(registerDto.Username)) 
			{
				return BadRequest("User Exists!");
			}
			using var hmac = new HMACSHA512();

			var user = new AppUser
			{
				UserName = registerDto.Username.ToLower(),
				PasswordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(registerDto.Password)),
				PasswordSalt = hmac.Key
			};

			dbContext.Users.Add(user);
			await dbContext.SaveChangesAsync();
			return Ok(user);
		}

		// /api/Account/Login
		[HttpPost]
		[Route("Login")]
		public async Task<IActionResult> Login([FromBody] LoginDto loginDto) 
		{
			var user = await dbContext.Users.FirstOrDefaultAsync(x => x.UserName == loginDto.Username.ToLower());
			if (user == null) 
			{
				return Unauthorized("Invalid Username");
			}

			using var hmac = new HMACSHA512(user.PasswordSalt);
			var computedHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(loginDto.Password));

			for(int i = 0; i < computedHash.Length; i++) 
			{
				if (computedHash[i] != user.PasswordHash[i]) 
				{
					return Unauthorized("Invalid Password");
				}
			}

			return Ok(user);
		}





		private async Task<bool> UserExistCheck(string username) 
		{
			return await dbContext.Users.AnyAsync(x => x.UserName.ToLower() == username.ToLower());
		}
	}

	
}
