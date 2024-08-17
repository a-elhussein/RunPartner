using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.EntityFrameworkCore;
using Run_Partner.DTOs;
using Run_Partner.Interfaces;
using Run_Partner.Models;

namespace Run_Partner.Data
{
	public class UserRepository(RunPartnerDbContext dbContext, IMapper mapper) : IUserRepository
	{
		public async Task<IEnumerable<AppUser>> GetAllAsync()
		{
			return await dbContext.Users
				.Include(x => x.Photos)
				.ToListAsync();
		}

		public async Task<MemberDto?> GetMemberAsync(string username)
		{
			return await dbContext.Users
				.Where(x => x.UserName == username)
				.ProjectTo<MemberDto>(mapper.ConfigurationProvider)
				.SingleOrDefaultAsync();
		}

		public async Task<IEnumerable<MemberDto>> GetMembersAsync()
		{
			return await dbContext.Users
				.ProjectTo<MemberDto>(mapper.ConfigurationProvider)
				.ToListAsync();

		}

		public async Task<AppUser?> GetUserByIdAsync(int id)
		{
			return await dbContext.Users.FindAsync(id);
		}

		public async Task<AppUser?> GetUserByUserNameAsync(string username)
		{
			return await dbContext.Users
				.Include(x => x.Photos)
				.SingleOrDefaultAsync(x => x.UserName == username);
		}

		public async Task<bool> SaveAllAsync()
		{
			return await dbContext.SaveChangesAsync() > 0;
		}

		public void Update(AppUser user)
		{
			dbContext.Entry(user).State = EntityState.Modified;
		}
	}
}
