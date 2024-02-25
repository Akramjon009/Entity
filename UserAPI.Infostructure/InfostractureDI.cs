using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using UserAPI.Infostructure.Persistence;

namespace UserAPI.Infostructure
{
    public static class InfostractureDI
    {
        public static IServiceCollection AddContexts(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ApplicationDbContext>(options =>
            {
                options.UseNpgsql(configuration.GetConnectionString("connector"));
            });
            return services;
        }
    }
}
