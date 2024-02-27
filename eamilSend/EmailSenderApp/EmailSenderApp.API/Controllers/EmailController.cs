﻿using EmailSenderApp.Application.Services.EmailServces;
using EmailSenderApp.Domain.Entites.Models;
using Microsoft.AspNetCore.Mvc;

namespace EmailSenderApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmailController : ControllerBase
    {
        private readonly IEmailService _emailService;

        public EmailController(IEmailService emailService)
        {
            _emailService = emailService;
        }

        [HttpPost]
        public async Task<IActionResult> SendEmail([FromForm] EmailModelDTO model)
        {

            await _emailService.SendEmailAsync(model);

            return Ok("Muvoffaqiyatli email yuborildi");
        }
    }
}
