using Azure.Identity;
using Microsoft.EntityFrameworkCore;
using Run_Partner.Models;
using System.Security.Cryptography;
using System.Text;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace Run_Partner.Data
{
	public class RunPartnerDbContext(DbContextOptions options) : DbContext(options)
	{
		public DbSet<AppUser> Users { get; set; }
		public DbSet<Photo> Photos { get; set; }

		// Seeding Data
		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);

			var users = new List<AppUser>();
			using var hmac = new HMACSHA512();

			// Add each user to the list
			users.Add(new AppUser
			{
				Id = -1,
				UserName = "Rosetta",
				PasswordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes("Pa$$word")),
				PasswordSalt = hmac.Key,
				Gender = "female",
				DateOfBirth = DateOnly.Parse("1967-12-14"),
				KnownAs = "Rosetta",
				Created = DateTime.Parse("2019-02-05"),
				LastActive = DateTime.Parse("2024-10-21"),
				Introduction = "Eu amet velit nostrud eu irure. Dolor pariatur commodo excepteur occaecat ad. Commodo mollit nulla ullamco sint qui laborum commodo veniam. Ut adipisicing excepteur duis laboris Lorem proident.\r\n",
				LookingFor = "In velit aliqua aute sint duis deserunt dolore nostrud consequat aute fugiat non. Nisi adipisicing magna qui est adipisicing elit quis sunt labore ut. Dolore ullamco nisi enim proident dolor eu. Exercitation enim deserunt esse do nostrud ex officia nisi et pariatur excepteur anim sit. Laboris sunt aliquip sunt sit sint sunt amet voluptate occaecat. Fugiat pariatur nisi deserunt aliquip exercitation culpa ullamco excepteur.\r\n",
				City = "Yonah",
				Country = "New Zealand",
			});

			users.Add(new AppUser
			{
				Id = -2,
				UserName = "Sasha",
				PasswordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes("Pa$$word")),
				PasswordSalt = hmac.Key,
				Gender = "female",
				DateOfBirth = DateOnly.Parse("1956-02-02"),
				KnownAs = "Sasha",
				Created = DateTime.Parse("2019-04-07"),
				LastActive = DateTime.Parse("2022-03-13"),
				Introduction = "Enim veniam magna sunt dolore commodo. Lorem laboris sit laboris incididunt proident laboris incididunt deserunt elit pariatur cupidatat cupidatat minim ullamco. Velit aliqua laborum nulla reprehenderit irure nisi nisi incididunt in non elit irure.\r\n",
				LookingFor = "Laboris aliquip exercitation pariatur laborum veniam cillum est eiusmod. Elit enim aliquip ex qui mollit et Lorem voluptate reprehenderit dolore Lorem Lorem cillum quis. Quis eiusmod ea duis minim non voluptate quis Lorem. Velit nulla quis ullamco incididunt non ad ea do ad incididunt mollit ut ad magna. Dolor cupidatat ad exercitation consequat exercitation aute et adipisicing amet ipsum dolore consequat esse. Minim do laborum ullamco consequat proident aliqua incididunt nulla.\r\n",
				City = "Olney",
				Country = "Denmark",
			});

			users.Add(new AppUser
			{
				Id = -3,
				UserName = "Cherie",
				PasswordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes("Pa$$word")),
				PasswordSalt = hmac.Key,
				Gender = "female",
				DateOfBirth = DateOnly.Parse("1961-07-13"),
				KnownAs = "Cherie",
				Created = DateTime.Parse("2021-04-28"),
				LastActive = DateTime.Parse("2023-07-30"),
				Introduction = "Non quis anim eiusmod excepteur cupidatat exercitation aute. Id tempor minim non commodo. Aliquip ipsum Lorem id deserunt aliqua reprehenderit nisi ad. Tempor laboris incididunt aute labore amet velit sit. Tempor consectetur nostrud nisi ad aute commodo. Velit aliquip ipsum est pariatur et in cupidatat ad et labore tempor cupidatat proident aute. Non sit enim ut labore qui eiusmod labore enim fugiat aliquip laborum.\r\n",
				LookingFor = "Eu sint enim laborum nisi nostrud do cillum adipisicing enim voluptate sunt velit. Excepteur amet ut aliqua excepteur dolor non ipsum aute anim ex proident consequat aliquip. Ex anim excepteur minim veniam eiusmod adipisicing. Exercitation magna aliquip excepteur esse et deserunt fugiat labore. Nostrud ex magna cupidatat magna ullamco dolore veniam anim. Cupidatat pariatur adipisicing veniam proident duis.\r\n",
				City = "Rutherford",
				Country = "Mauritania",
			});

			users.Add(new AppUser
			{
				Id = -4,
				UserName = "Josie",
				PasswordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes("Pa$$word")),
				PasswordSalt = hmac.Key,
				Gender = "female",
				DateOfBirth = DateOnly.Parse("1983-11-24"),
				KnownAs = "Josie",
				Created = DateTime.Parse("2020-05-31"),
				LastActive = DateTime.Parse("2021-11-04"),
				Introduction = "Amet nisi ipsum aliquip reprehenderit excepteur eu ea et quis tempor. Proident officia pariatur mollit cupidatat nulla deserunt adipisicing ut velit. Labore eiusmod consequat esse ipsum elit est proident occaecat Lorem ut amet officia. Dolore adipisicing labore eu cillum id id consectetur enim consequat velit labore mollit proident.\r\n",
				LookingFor = "Anim id eiusmod exercitation aliqua non reprehenderit culpa ea veniam aliquip culpa officia adipisicing. Sunt in velit fugiat laboris pariatur dolore officia proident et cillum excepteur. Occaecat nostrud id sit enim esse proident fugiat ipsum elit eu exercitation mollit mollit nulla. Aute irure consectetur do reprehenderit id. Cillum mollit ex tempor ea minim cupidatat aute fugiat Lorem id reprehenderit ut laborum deserunt. Adipisicing consectetur labore ad officia nisi consectetur.\r\n",
				City = "Jenkinsville",
				Country = "Latvia",
			});

			users.Add(new AppUser
			{
				Id = -5,
				UserName = "Eugenia",
				PasswordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes("Pa$$word")),
				PasswordSalt = hmac.Key,
				Gender = "female",
				DateOfBirth = DateOnly.Parse("1959-06-03"),
				KnownAs = "Eugenia",
				Created = DateTime.Parse("2022-08-31"),
				LastActive = DateTime.Parse("2021-09-08"),
				Introduction = "Sunt ipsum non laborum ea eu excepteur nulla. Excepteur Lorem sint dolor ut sint ipsum incididunt id dolore. Consectetur aute sit in ut nisi sint consectetur.\r\n",
				LookingFor = "Sit Lorem non adipisicing aute reprehenderit. Aute sunt consequat officia ullamco cupidatat ex laborum sunt exercitation qui nulla tempor mollit. Exercitation Lorem adipisicing sit occaecat cillum irure. Sint esse ea ex quis eu. Officia eu et ea minim reprehenderit excepteur pariatur aliquip culpa ullamco aute. Anim incididunt exercitation magna enim aute Lorem id culpa consequat adipisicing commodo ullamco. Elit culpa elit esse enim et.\r\n",
				City = "Veyo",
				Country = "South Africa",
			});

			users.Add(new AppUser
			{
				Id = -6,
				UserName = "Crawford",
				PasswordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes("Pa$$word")),
				PasswordSalt = hmac.Key,
				Gender = "male",
				DateOfBirth = DateOnly.Parse("1985-02-25"),
				KnownAs = "Crawford",
				Created = DateTime.Parse("2019-12-18"),
				LastActive = DateTime.Parse("2023-08-08"),
				Introduction = "Laboris consequat ut eu mollit dolore sint aliquip. Pariatur ea minim et anim mollit sint sunt ullamco velit officia. Excepteur excepteur aliqua aliquip proident anim ipsum cupidatat eu non culpa sint dolor anim veniam. Cupidatat id nostrud voluptate excepteur. Reprehenderit Lorem excepteur quis qui sunt.\r\n",
				LookingFor = "Officia ullamco tempor magna eu do cupidatat cillum do. Nisi irure ea aliqua dolor culpa ea cillum Lorem enim. Cillum tempor eu cupidatat qui aute tempor excepteur incididunt eu tempor. Id elit laboris duis ex esse magna qui. Anim Lorem adipisicing dolor anim occaecat aute veniam sint excepteur. Laborum ut sunt ut magna ad consequat enim. Sint cupidatat qui excepteur mollit proident irure veniam in duis excepteur consequat.\r\n",
				City = "Defiance",
				Country = "Senegal",
			});

			users.Add(new AppUser
			{
				Id = -7,
				UserName = "Leblanc",
				PasswordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes("Pa$$word")),
				PasswordSalt = hmac.Key,
				Gender = "male",
				DateOfBirth = DateOnly.Parse("1952-01-29"),
				KnownAs = "Leblanc",
				Created = DateTime.Parse("2019-01-09"),
				LastActive = DateTime.Parse("2022-07-17"),
				Introduction = "Dolore dolor anim velit esse consequat id aute voluptate. Adipisicing aliqua ea sunt consectetur et aliqua excepteur. In nulla dolore exercitation ea aliqua fugiat irure in eiusmod exercitation aute occaecat esse. Sint dolore nostrud adipisicing nostrud consequat duis veniam nisi qui nulla.\r\n",
				LookingFor = "Aute ipsum ex nostrud dolore ad sint. Lorem id nisi irure laboris aliqua officia pariatur cupidatat exercitation irure. Enim in dolore nostrud nisi occaecat dolor exercitation culpa dolore. Magna tempor laborum sunt velit fugiat qui. Duis proident velit deserunt eiusmod mollit aliqua nostrud duis.\r\n",
				City = "Shady Grove",
				Country = "Greece",
			});

			users.Add(new AppUser
			{
				Id = -8,
				UserName = "Scott",
				PasswordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes("Pa$$word")),
				PasswordSalt = hmac.Key,
				Gender = "male",
				DateOfBirth = DateOnly.Parse("1994-04-27"),
				KnownAs = "Scott",
				Created = DateTime.Parse("2020-09-19"),
				LastActive = DateTime.Parse("2021-06-29"),
				Introduction = "Non mollit in ad aute eiusmod nulla aute tempor proident. Reprehenderit occaecat laboris ipsum esse reprehenderit sunt irure tempor in irure dolore cillum. Mollit ullamco voluptate magna laborum do do veniam dolor aliqua culpa ea reprehenderit voluptate ut.\r\n",
				LookingFor = "Sunt tempor voluptate id nulla dolore aliquip enim enim occaecat occaecat Lorem ex dolore. Aliqua excepteur Lorem ut laborum proident pariatur incididunt nulla. Non veniam ad adipisicing sunt dolor labore dolore. Cillum sunt culpa duis nulla tempor. Amet mollit ea ex magna. Officia non tempor magna aute irure anim adipisicing. Amet culpa nostrud voluptate laborum.\r\n",
				City = "Hickory",
				Country = "Lithuania",
			});

			// Add the users to the model builder
			modelBuilder.Entity<AppUser>().HasData(users);

			modelBuilder.Entity<Photo>().HasData(
			   new Photo
			   {
				   Id = -1,
				   Url = "https://randomuser.me/api/portraits/women/10.jpg",
				   IsMain = true,
				   AppUserId = -1
			   },
			   new Photo
			   {
				   Id = -2,
				   Url = "https://randomuser.me/api/portraits/women/20.jpg",
				   IsMain = true,
				   AppUserId = -2
			   },
			   new Photo
			   {
				   Id = -3,
				   Url = "https://randomuser.me/api/portraits/women/30.jpg",
				   IsMain = true,
				   AppUserId = -3
			   },
			   new Photo
			   {
				   Id = -4,
				   Url = "https://randomuser.me/api/portraits/women/40.jpg",
				   IsMain = true,
				   AppUserId = -4
			   },
			   new Photo
			   {
				   Id = -5,
				   Url = "https://randomuser.me/api/portraits/women/50.jpg",
				   IsMain = true,
				   AppUserId = -5
			   },
			   new Photo
			   {
				   Id = -6,
				   Url = "https://randomuser.me/api/portraits/men/10.jpg",
				   IsMain = true,
				   AppUserId = -6
			   },
			   new Photo
			   {
				   Id = -7,
				   Url = "https://randomuser.me/api/portraits/men/20.jpg",
				   IsMain = true,
				   AppUserId = -7
			   },
			   new Photo
			   {
				   Id = -8,
				   Url = "https://randomuser.me/api/portraits/men/30.jpg",
				   IsMain = true,
				   AppUserId = -8
			   }
		   );


		}


	}
}