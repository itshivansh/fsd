﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AuthenticationService.Models;

namespace AuthenticationService.Repository
{
    public class AuthRepository : IAuthRepository
    {
        private readonly AuthDbContext authDbContext;
        public AuthRepository(AuthDbContext _authDbContext)
        {
            authDbContext = _authDbContext;
        }
        public bool CreateUser(User user)
        {
            authDbContext.Users.Add(user);
            authDbContext.SaveChanges();
            return true;
        }

        public bool IsUserExists(string userId)
        {
            var user = authDbContext.Users.FirstOrDefault(u => u.UserId == userId);
            if (user != null)
            {
                return true;
            }
            return false;
        }

        public bool LoginUser(User user)
        {
            var _user = authDbContext.Users.FirstOrDefault(u => u.UserId == user.UserId && u.Password == user.Password);
            if (_user != null)
            {
                return true;
            }
            return false;
        }
    }
}
