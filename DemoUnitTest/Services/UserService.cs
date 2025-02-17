﻿using System;
using DemoUnitTest.Models;
using DemoUnitTest.Repositories;

namespace DemoUnitTest.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public User GetUserById(int id)
        {
            return _userRepository.GetById(id);
        }
    }
}

