using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using UsersApi.Dtos;

namespace UsersApi.DataAccess
{
    public interface IDataAccess
    {
        public List<User> GetUsers();
        public User GetUserById(int id);
        public User InsertUser(string name, string email);
    }
}