using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using SportsClubsLib.Data;

namespace SportsClubsLib.Extensions
{
    public static class SportsClubsDataInstaller
    {
        public static IServiceCollection AddSportsClubsData(this IServiceCollection services, string connectionString)
        {
            services.AddDbContextPool<SportsClubsDbContext>(options =>
                options
                    .UseSqlServer(connectionString, builder => builder.MigrationsAssembly("SportsClubsLib")) 
            );

            return services;
        }
    }
}
