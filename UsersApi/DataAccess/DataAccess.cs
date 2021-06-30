using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using UsersApi.Dtos;

namespace UsersApi.DataAccess
{
    public class DataAccess : IDataAccess
    {
        private List<User> usersList = new List<User>();

        public DataAccess()
        {
            usersList.Add(new User(){ IdUser = 1, Name = "Paco", Email = "paco@gmail.com"});
            usersList.Add(new User(){ IdUser = 2, Name = "Jose", Email = "jose@gmail.com"});
            usersList.Add(new User(){ IdUser = 3, Name = "Jesus", Email = "jesus@gmail.com"});
        }

        public List<User> GetUsers()
        {
            return usersList;
        }

        public User GetUserById(int id)
        {
            var user = usersList.FirstOrDefault(x => x.IdUser == id);
            throw new Exception("trone");
            return user;
        }

        public User InsertUser(string name, string email)
        {
            var user = new User {Name = name, Email = email, IdUser = usersList.Max(x => x.IdUser) + 1};
            usersList.Add(user);
            return user;
        }
    }
}