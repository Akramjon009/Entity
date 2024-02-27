using EmailSenderApp.Domain.Entites.Models;
using System.ComponentModel.DataAnnotations;

namespace EmailSenderApp.Application.Services.EmailServces
{
    public interface IEmailService
    {
        public Task SendEmailAsync(EmailModelDTO model);
    }
}
