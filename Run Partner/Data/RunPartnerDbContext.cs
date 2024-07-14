using Azure.Identity;
using Microsoft.EntityFrameworkCore;
using Run_Partner.Models;

namespace Run_Partner.Data
{
	public class RunPartnerDbContext(DbContextOptions options) : DbContext(options)
	{
        public DbSet<AppUser> Users { get; set; }

	//	protected override void OnModelCreating(ModelBuilder modelBuilder)
	//	{
	//		base.OnModelCreating(modelBuilder);
	//		//Seeding Test Data for user
	//		var users = new List<AppUser>() 
	//		{
	//			new AppUser()
	//			{
	//				Id = Guid.Parse("3d655afc-1939-429f-ac99-cfb3140218f9"),
	//				UserName = "Ahmed"
	//			},

	//			new AppUser()
	//			{
	//				Id = Guid.Parse("f0c07f18-a85b-4b16-860e-5ed4bcee4c83"),
	//				UserName = "Abbas"
	//			},

	//			new AppUser()
	//			{
	//				Id = Guid.Parse("dad4aee9-fa78-44eb-ba21-beb10274972f"),
	//				UserName = "Joha"
	//			},
	//		};
			
	//		//Seed Users to db
	//		modelBuilder.Entity<AppUser>().HasData(users);
	//	}
	}
}
