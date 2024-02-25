using UserAPI.Application.Service.UserServices.Interfaces;
using UserAPI.Domen.Entitys.UserModels.DTOs;

namespace UserAPI.Application.Service.UserServices.Classes
{
    internal class UserProfileService : IUserProfileService
    {
        public Task<Domen.Model.UserModels.Models.UserProfile> CreateUserProfileAsync(UserProfileDto User)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteUserProfileAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Domen.Model.UserModels.Models.UserProfile> GetUserProfileAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Domen.Model.UserModels.Models.UserProfile> GetUserProfileAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateUserProfileAsync(int id, UserProfileDto User)
        {
            throw new NotImplementedException();
        }
    }
}
