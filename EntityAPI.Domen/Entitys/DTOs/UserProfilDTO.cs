using EntityAPI.Domen.Entitys.Enums;
using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace EntityAPI.Domen.Entitys.DTOs
{
    public class UserProfileDTO
    {
        [NotMapped]
        public IFormFile Picture { get; set; }
        public string FullName { get; set; }
        public string Phone { get; set; }
        public Role UserRole { get; set; }


        [MinLength(5), MaxLength(30)]
        public required string Login { get; set; }


        [MinLength(8), MaxLength(15)]
        public required string Password { get; set; }


        [JsonIgnore]
        public string PicturePath { get; set; }
    }
}
