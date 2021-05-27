using System;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Timesheets.Data.Interfaces;
using Timesheets.Domain.Interfaces;
using Timesheets.Infrastructure.Extensions;
using Timesheets.Models;
using Timesheets.Models.Dto;

namespace Timesheets.Domain.Implementation
{
    public class UserManager : IUserManager
    {
        private readonly IUserRepo _userRepo;

        public UserManager(IUserRepo userRepo)
        {
            _userRepo = userRepo;
        }

        public async Task<User> GetUser(LoginRequest request)
        {
            var passwordHash = GetPasswordHash(request.Password);
            var user = await _userRepo.GetByLoginAndPasswordHash(request.Login, passwordHash);

            return user;
        }

        public async Task<User> GetUserById(Guid id)
        {
            User user = await _userRepo.GetById(id);

            return user;
        }

        public async Task<Guid> CreateUser(CreateUserRequest request)
        {
            request.EnsureNotNull(nameof(request));

            var user = new User
            {
                Id = Guid.NewGuid(),
                Username = request.Username,
                PasswordHash = GetPasswordHash(request.Password),
                Role = request.Role
            };

            await _userRepo.CreateUser(user);

            return user.Id;
        }

        private static byte[] GetPasswordHash(string password)
        {
            using (var sha1 = new SHA1CryptoServiceProvider())
            {
                return sha1.ComputeHash(Encoding.Unicode.GetBytes(password));
            }
        }

        public async Task UpdateUserById(UserDTO userDTO)
        {
            User user = new User
            {
                Id = userDTO.Id,
                Role = userDTO.Role,
                Username = userDTO.Username
            };
            await _userRepo.UpdateUser(user);
        }

        public async Task DeleteUser(Guid id)
        {
            await _userRepo.DeleteUser(id);
        }
    }
}