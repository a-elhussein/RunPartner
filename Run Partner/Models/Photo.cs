using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Run_Partner.Models
{
	[Table("Photos")]
	public class Photo
	{
		public int Id { get; set; }
		[Required]
		public string Url { get; set; }
        public bool IsMain { get; set; }
        public string? PublicId { get; set; }

        // Navigation Properties
        public int AppUserId { get; set; }
		public AppUser AppUser { get; set; } = null!;

    }
}
