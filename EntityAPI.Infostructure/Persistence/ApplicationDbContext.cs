using EntityAPI.Domen.Entitys.Models;
using Microsoft.EntityFrameworkCore;

namespace EntityAPI.Infostructure.Persistence
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }
        public DbSet<UserProfileDTO> UserProfiles { get; set; }
    }
}
