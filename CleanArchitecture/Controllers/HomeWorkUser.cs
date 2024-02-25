using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UserAPI.Application.Service.UserServices.Interfaces;
using UserAPI.Domen.Entitys.UserModels.DTOs;
using UserAPI.Domen.Model.UserModels.Models;

namespace CleanArchitecture.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class HomeWorkUser : ControllerBase
    {
        private readonly IUserProfileService _userService;
        public HomeWorkUser(IUserProfileService userService)
        {
            _userService = userService;
        }
        [HttpGet]
        public Task<string> CreateUserProfileAsync(UserProfileDto User) 
        {
            return _userService.CreateUserProfileAsync(User);
        }

        [HttpGet]
        public Task<UserProfile> GetUserProfileByIdAsync(int id) 
        {
            return _userService.GetUserProfileByIdAsync(id);
        }

        [HttpDelete]
        public Task<bool> DeleteUserProfileAsync(int id) 
        {
            return _userService.DeleteUserProfileAsync(id);
        }

        [HttpPatch]
        public Task<bool> UpdateUserProfile(int id, UserProfileDto User)
        {
            return _userService.UpdateUserProfileAsync(id, User);
        }

        [HttpPost]
        public Task<IEnumerable<UserProfile>> GetUserProfileAsync() 
        {
            return _userService.GetUserProfileAsync();
        }

    }
}
