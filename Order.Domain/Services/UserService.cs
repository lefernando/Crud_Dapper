﻿using Order.Domain.Interfaces.Services;
using Order.Domain.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Order.Domain.Services
{
    public class UserService : IUserService
    {
        public Task<bool> AuthenticationAsync(UserModel user)
        {
            throw new NotImplementedException();
        }

        public Task CreateAsync(UserModel user)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(string userId)
        {
            throw new NotImplementedException();
        }

        public Task<UserModel> GetByIdAsync(UserModel userId)
        {
            throw new NotImplementedException();
        }

        public Task<List<UserModel>> ListByFiltersAsync(string userId = null, string name = null)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(UserModel user)
        {
            throw new NotImplementedException();
        }
    }
}
