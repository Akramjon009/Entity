using EmailSenderApp.Application.Services.EmailSendServces;
using EmailSenderApp.Domain.Entites.Models;
using EmailSenderApp.Domain.Entites.UserEmail;

namespace EmailSenderApp.Application.Services.UserEmailService
{
    public class UserService : IUserService
    {
        private readonly ApplicationDbContext

        public Task<string> InsertEmailAsync(NewUserEmail email)
        {
            
        }
    }
}
