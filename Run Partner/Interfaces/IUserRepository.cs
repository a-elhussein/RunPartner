using Run_Partner.DTOs;
using Run_Partner.Models;

namespace Run_Partner.Interfaces
{
	public interface IUserRepository
	{
		void Update(AppUser user);
		Task<bool> SaveAllAsync();
		Task<IEnumerable<AppUser>> GetAllAsync();
		Task<AppUser?> GetUserByIdAsync(int id);
		Task<AppUser?> GetUserByUserNameAsync(string username);
		Task<IEnumerable<MemberDto>> GetMembersAsync();
		Task<MemberDto?> GetMemberAsync(string username);

	}
}
