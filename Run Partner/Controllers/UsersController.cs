using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Run_Partner.Data;
using Run_Partner.Models;

namespace Run_Partner.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class UsersController(RunPartnerDbContext context) : ControllerBase
	{
		
		[HttpGet]
		[Route("GetAll")]
		public async Task<ActionResult<AppUser>> GetUsers() 
		{
			var users = await context.Users.ToListAsync();

			return Ok(users);

		}

		[Authorize]
		[HttpGet]
		[Route("{id:guid}")]

		public async Task<ActionResult<AppUser>> GetUser([FromRoute] Guid id) 
		{
			var user = await context.Users.FirstOrDefaultAsync(x => x.Id == id);
			return Ok(user);
		}

		
	}
}
