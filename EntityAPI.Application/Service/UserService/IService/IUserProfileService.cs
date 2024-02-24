using EntityAPI.Domen.Entitys.DTOs;
using EntityAPI.Domen.Entitys.Models;
using System.Runtime.InteropServices;

namespace EntityAPI.Application.Service.UserService.Interfaces
{
    public interface IUserProfileService
    {
        public Task<UserProfileDTO> CreateUserProfileAsync(UserProfileDTO User);
        public Task<List<UserProfileDTO>> GetUserProfileAsync();
        public Task<UserProfile> GetUsersProfileByIdAsync(int UserId);
        public Task<bool> DeleteUserProfileAsync (int UserId);
        public Task<bool> UpdateUserProfileAsync(int UserId,UserProfileDTO User);
    }
}
