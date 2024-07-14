using System.ComponentModel.DataAnnotations;

namespace Run_Partner.DTOs
{
	public class LoginDto
	{
        [Required]
        public string Username { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
