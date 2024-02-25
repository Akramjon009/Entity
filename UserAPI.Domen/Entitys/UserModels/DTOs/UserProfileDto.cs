using System.ComponentModel.DataAnnotations;
using UserAPI.Domen.Entitys.UserModels.Enum;

namespace UserAPI.Domen.Entitys.UserModels.DTOs
{
    public class UserProfileDto
    {
        public required string FullName { get; set; }
        public required Role UserRole { get; set; }
        public int age { get; set; }

        [MinLength(6), MaxLength(30)]
        public required string email { get; set; }
    }
}
