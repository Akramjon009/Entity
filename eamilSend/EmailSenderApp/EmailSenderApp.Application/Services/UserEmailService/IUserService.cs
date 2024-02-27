using EmailSenderApp.Domain.Entites.Models;
using EmailSenderApp.Domain.Entites.UserEmail;

namespace EmailSenderApp.Application.Services.EmailSendServces
{
    internal interface IUserService
    {
        public Task<string> InsertEmailAsync(NewUserEmail email);
    }
}
