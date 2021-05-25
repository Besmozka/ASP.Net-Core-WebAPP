﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Timesheets.Models;
using Timesheets.Models.Dto;

namespace Timesheets.Domain.Interfaces
{
    public interface IUserManager
    {
        /// <summary> Возвращает пользователя по логину и паролю </summary>
        Task<User> GetUser(LoginRequest request);

        /// <summary> Возвращает пользователя по ID </summary>
        Task<User> GetUserById(Guid id);

        /// <summary> Создает нового пользователя </summary>
        Task<Guid> CreateUser(CreateUserRequest request);
        Task DeleteUser(Guid id);
    }
}