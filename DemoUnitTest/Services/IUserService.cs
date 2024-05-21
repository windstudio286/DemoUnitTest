using System;
using DemoUnitTest.Models;

namespace DemoUnitTest.Services
{
    public interface IUserService
    {
        User GetUserById(int id);
    }
}

