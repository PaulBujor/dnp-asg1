using FamilyTree.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace FamilyTree.Data
{
    public class InMemoryUserService : IUserService
    {
        private List<User> users;

        public InMemoryUserService()
        {
            User adminUser = new User("admin", "admin");
            users = new[] {
            adminUser
        }.ToList();
        }


        public User ValidateUser(string userName, string password)
        {
            User first = users.FirstOrDefault(user => user.UserName.Equals(userName));
            if (first == null)
            {
                throw new Exception("User not found");
            }

            if (!first.Password.Equals(password))
            {
                throw new Exception("Incorrect password");
            }

            return first;
        }

        public void ValidateNewUser(string userName, string password)
        {
            User first = users.FirstOrDefault(user => user.UserName.Equals(userName));
            if (first != null)
            {
                throw new Exception("Username already exists. Use another username");
            }
            RegisterNewUser(userName, password);
           
        }

        public void RegisterNewUser(string userName, string password)
        {
            User newUser = new User(userName, password);
            users.Add(newUser);
        }
    }
}
