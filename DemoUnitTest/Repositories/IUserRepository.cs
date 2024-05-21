using System;
using DemoUnitTest.Models;

namespace DemoUnitTest.Repositories
{
    public interface IUserRepository
    {
        User GetById(int id);
    }
}

