using EntityAPI.Application.Service.UserService.Interfaces;
using EntityAPI.Domen.Entitys.DTOs;
using EntityAPI.Domen.Entitys.Models;
using EntityAPI.Infostructure.Persistence;

namespace EntityAPI.Application.Service.UserService.Calsses
{
    public class UserProfileService : IUserProfileService
    {
        private readonly ApplicationDbContext _contect;
        public UserProfileService(ApplicationDbContext contect)
        {
            _contect = contect;
        }

        public Task<UserProfileDTO> CreateUserProfileAsync(UserProfileDTO User)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteUserProfileAsync(int UserId)
        {
            throw new NotImplementedException();
        }

        public Task<List<UserProfileDTO>> GetUserProfileAsync()
        {
            throw new NotImplementedException();
        }

        public Task<UserProfile> GetUsersProfileByIdAsync(int UserId)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateUserProfileAsync(int UserId,UserProfileDTO user)
        {
            throw new NotImplementedException();
        }
    }
}
