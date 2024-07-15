using System.ComponentModel.DataAnnotations;

namespace Run_Partner.DTOs
{
	public class UserDto
	{
		[Required]
        public string Username { get; set; }
		[Required]
		public string Token { get; set; }
		
	}
}
