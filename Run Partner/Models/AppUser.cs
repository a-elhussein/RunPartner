using Run_Partner.Extensions;
using System.ComponentModel.DataAnnotations;

namespace Run_Partner.Models
{
	public class AppUser
	{
        public int Id { get; set; }
        [Required]
        public  string UserName { get; set; }
        public byte[] PasswordHash { get; set; } = [];
        public byte[] PasswordSalt { get; set; } = [];
        public DateOnly DateOfBirth { get; set; }
        [Required]
        public string KnownAs { get; set; }
        public DateTime Created { get; set; } = DateTime.UtcNow;
        public DateTime LastActive { get; set; } = DateTime.UtcNow;
        [Required]
        public string Gender { get; set; }
        [Required] 
        public string Introduction { get; set; }
        [Required]
        public string City { get; set; }
        [Required]
        public string Country { get; set; }
        [Required]
        public string? LookingFor { get; set; }
        public List<Photo> Photos { get; set; } = [];

        //public int GetAge() 
        //{
        //    return DateOfBirth.CalculateAge();
        //}
    }
}
