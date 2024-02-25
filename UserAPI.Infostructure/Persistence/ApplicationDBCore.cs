using Microsoft.EntityFrameworkCore;
using UserAPI.Domen.Model.UserModels.Models;

namespace UserAPI.Infostructure.Persistence
{
    public class ApplicationDBCore : DbContext
    {
        public class ApplicationDbContext : DbContext
        {
            public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
                : base(options)
            {

            }
            public DbSet<UserProfile> UserProfiles { get; set; }
        }
    }
}
