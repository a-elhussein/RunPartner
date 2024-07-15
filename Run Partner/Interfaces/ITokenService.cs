using Run_Partner.Models;

namespace Run_Partner.Interfaces
{
	public interface ITokenService
	{
		string CreateToken(AppUser user);
	}
}
