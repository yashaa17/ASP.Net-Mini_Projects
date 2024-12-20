﻿using Green_Basket.Models;
namespace Green_Basket.Service
{
    public interface IUserService
    {
        List<User> GetUsers();
        User GetUser(int id);
        bool Insert(User user);
        bool Update(User user);

        bool Delete(int id);

    }
}
