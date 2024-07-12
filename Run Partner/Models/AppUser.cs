using System.ComponentModel.DataAnnotations;

namespace Run_Partner.Models
{
	public class AppUser
	{
        public Guid Id { get; set; }
        public required string UserName { get; set; }
    }
}
