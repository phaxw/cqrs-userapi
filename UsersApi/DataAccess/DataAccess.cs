using System;
using System.Collections.Generic;
using System.Linq;
using UsersApi.Dtos;

namespace UsersApi.DataAccess
{
    public class DataAccess : IDataAccess
    {
        private List<User> _usersList = new List<User>();

        public DataAccess()
        {
            _usersList.Add(new User(){ IdUser = 1, Name = "Paco", Email = "paco@gmail.com"});
            _usersList.Add(new User(){ IdUser = 2, Name = "Jose", Email = "jose@gmail.com"});
            _usersList.Add(new User(){ IdUser = 3, Name = "Jesus", Email = "jesus@gmail.com"});
        }

        public List<User> GetUsers()
        {
            return _usersList;
        }

        public User GetUserById(int id)
        {
            var user = _usersList.FirstOrDefault(x => x.IdUser == id);
            throw new NullReferenceException("trone");
            return user;
        }

        public User InsertUser(string name, string email)
        {
            var user = new User {Name = name, Email = email, IdUser = _usersList.Max(x => x.IdUser) + 1};
            _usersList.Add(user);
            return user;
        }
    }
}