using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Run_Partner.Data;
using Run_Partner.Models;

namespace Run_Partner.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class BuggyController(RunPartnerDbContext context) : ControllerBase
	{
		[Authorize]
		[HttpGet]
		[Route("auth")]
		public ActionResult<string> GetAuth()
		{
			return "secret text";
		}

		[HttpGet]
		[Route("not-found")]
		public ActionResult<AppUser> GetNotFound()
		{
			Guid userId = new Guid("54bd0cd8-4c9c-4c51-8f30-ee7bc470a428");
			var thing = context.Users.Find(userId);
			if (thing == null) return NotFound();
			return thing;
		}

		[HttpGet]
		[Route("server-error")]
		public ActionResult<AppUser> GetServerError()
		{
			
			Guid userId = new Guid("54bd0cd8-4c9c-4c51-8f30-ee7bc470a428");
			var thing = context.Users.Find(userId) ?? throw new Exception("A bad thing has happened");
			return thing;
		}

		[HttpGet]
		[Route("bad-request")]
		public ActionResult<string> GetBadRequest()
		{
			return BadRequest("This was not a good request");
		}
	}
}
