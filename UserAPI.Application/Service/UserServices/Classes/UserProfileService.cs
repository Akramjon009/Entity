using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using UserAPI.Application.Service.UserServices.Interfaces;
using UserAPI.Domen.Entitys.UserModels.DTOs;
using UserAPI.Domen.Model.UserModels.Models;
using UserAPI.Infostructure.Persistence;

namespace UserAPI.Application.Service.UserServices.Classes
{
    internal class UserProfileService : IUserProfileService
    {
        private readonly ApplicationDbContext _context;
        public UserProfileService(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<string> CreateUserProfileAsync(UserProfileDto User)
        {
            try
            {
                var model = new UserProfile()
                {
                    FullName = User.FullName,
                    UserRole = User.UserRole,
                    age = User.age,
                    email = User.email
                };
                await _context.UserProfiles.AddAsync(model);
                await _context.SaveChangesAsync();
                return "Qo'shildi";
            }
            catch
            {
                return "Qo'shilmadi Error mavjud";
            }
        }

        public async Task<bool> DeleteUserProfileAsync(int id)
        {
            try
            {
                var model = await _context.UserProfiles.FirstOrDefaultAsync(x => x.Id == id);
                if (model is not null)
                {
                    _context.UserProfiles.Remove(model);
                    await _context.SaveChangesAsync();
                    return true;
                }
                else
                {
                    return false;
                }

            }
            catch
            {
                return false;
            }
        }

        public async Task<IEnumerable<UserProfile>> GetUserProfileAsync()
        {
            try
            {
                return await _context.UserProfiles.ToListAsync();
            }
            catch
            {
                return Enumerable.Empty<UserProfile>();
            }
        }

        public async Task<UserProfile> GetUserProfileByIdAsync(int id)
        {
            try
            {
                var x = await _context.UserProfiles.FirstOrDefaultAsync(x => x.Id == id);
                if (x is not null)
                {
                    return x;
                }
                return null;
            }
            catch
            {
                return null;
            }
        }

        public async Task<bool> UpdateUserProfileAsync(int id, UserProfileDto User)
        {
            try
            {
                var x = await _context.UserProfiles.FirstOrDefaultAsync(x => x.Id == id);
                if (x != null)
                {
                    
                    _context.SaveChanges();
                    return true;
                }
                return false;
            }
            catch
            {
                return false;
            }
        }
    }
}
