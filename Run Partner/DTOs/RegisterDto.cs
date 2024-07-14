using System.ComponentModel.DataAnnotations;

namespace Run_Partner.DTOs
{
	public class RegisterDto
	{
		[Required]
        [MaxLength(15)]
        public string Username { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
