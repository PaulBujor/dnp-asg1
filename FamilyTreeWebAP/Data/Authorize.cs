using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FamilyTree.Data.Models;

namespace FamilyTreeWebAP.Data
{
    public class Authorize: IAuthorize
    {
        private IFileStorage _fileStorage = new FileStorage();
        
        public async Task<User> ValidateUser(string username,string password)
        {
            List<User> tmpUsers = await _fileStorage.GetUsers();
            Console.WriteLine(tmpUsers.Count);
            for (int i = 0; i < tmpUsers.Count; i++)
            {
                if (tmpUsers[i].userName.Equals(username) && tmpUsers[i].password.Equals(password))
                {
                    return tmpUsers.ElementAt(i);
                }
            }

            return null;

        }

        public async Task RegisterUser(string username,string password)
        {
            
            List<User> tmpUsers = await _fileStorage.GetUsers();
           
            User first = tmpUsers.FirstOrDefault(user => user.userName.Equals(username));

            if (first != null)
            {
                throw new ArgumentException("Username already exists. Use another username");
                
            }
            await _fileStorage.RegisterUser(username, password);
            
            
        }
    }
}