using EntityAPI.Domen.Entitys.DTOs;
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
