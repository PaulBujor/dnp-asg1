using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FamilyTree.Data.Models
{
    public class User
    {
        public string UserName { get; set; }
        public int SecurityLevel { get; set; }
        public string Password { get; set; }

        public User (string username, string password)
        {
            UserName = username;
            Password = password;
        }
    }
}
