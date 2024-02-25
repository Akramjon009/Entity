using UserAPI.Domen.Entitys.UserModels.DTOs;
using UserAPI.Domen.Model.UserModels.Models;

namespace UserAPI.Application.Service.UserServices.Interfaces
{
    public interface IUserProfileService
    {
        public Task<UserProfile> CreateUserProfileAsync(UserProfileDto User);
        public Task<bool> UpdateUserProfileAsync(int id, UserProfileDto User);
        public Task<bool> DeleteUserProfileAsync(int id);
        public Task<UserProfile> GetUserProfileAsync();
        public Task<UserProfile> GetUserProfileAsync(int id);
    }
}
