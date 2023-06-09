﻿using Order.Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Order.Domain.Interfaces.Repositories
{
    public interface IUserRepository
    {
        Task CreateAsync(UserModel user);
        Task UpdateAsync(UserModel user);
        Task DeleteAsync(string userId);
        Task<UserModel> GetByIdAsync(string userId);
        Task<List<UserModel>> ListByFilterAsync(string userId = null, string name = null);
        Task<bool> ExistByIdAsync(string userId);
        Task<bool> ExistByLoginAsync(string loginId);
    }
}
