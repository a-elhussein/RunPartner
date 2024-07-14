using System.ComponentModel.DataAnnotations;

namespace Run_Partner.Models
{
	public class AppUser
	{
        public Guid Id { get; set; }
        [Required]
        public  string UserName { get; set; }
        [Required]
        public required byte[] PasswordHash { get; set; }
        [Required]
        public required byte[] PasswordSalt { get; set; }
    }
}
