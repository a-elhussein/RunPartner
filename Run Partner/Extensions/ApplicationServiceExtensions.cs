using Microsoft.EntityFrameworkCore;
using Run_Partner.Data;
using Run_Partner.Interfaces;
using Run_Partner.Services;

namespace Run_Partner.Extensions
{
	public static class ApplicationServiceExtensions
	{
		public static IServiceCollection AddApplicationServices(this IServiceCollection services, IConfiguration config) 
		{
			services.AddDbContext<RunPartnerDbContext>(options =>
			{
				options.UseSqlServer(config.GetConnectionString("RunPartnerConnectionString"));
			});
			services.AddCors();

			services.AddControllers();
			services.AddEndpointsApiExplorer();
			services.AddSwaggerGen();

			services.AddScoped<ITokenService, TokenService>();

			return services;
		}
	}
}
