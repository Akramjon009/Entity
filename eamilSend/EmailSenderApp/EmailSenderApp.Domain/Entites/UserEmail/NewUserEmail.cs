using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmailSenderApp.Domain.Entites.UserEmail
{
    public class NewUserEmail
    {
        public int id {  get; set; }
        public required string Email { get; set; }
        public string password { get; set; }
        public string FullName { get; set; }
        public int Age { get; set; }
    }
}
