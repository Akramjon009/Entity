using EmailSenderApp.Domain.Entites.UserEmail;
using Microsoft.EntityFrameworkCore;

namespace EmailSenderApp.Infrastructure
{
    public class ApplicationDbContext : DbContext 
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
            => Database.Migrate();
        public DbSet<NewUserEmail> UserEmails { get; set; }
    }
}
