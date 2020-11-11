using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using FamilyTree.Data.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Diagnostics;
using Models;

namespace FamilyTreeWebAP.Data
{
    public class FileStorage: IFileStorage
    {
        private string storageFile = "adults.json";
        private List<Adult> adults;
        private List<User> users;
        private string userFile = "users.json";
        

        public FileStorage()
        {
            if (!File.Exists(storageFile))
            {
                Seed();
                WriteAdultsToFile();
            }
            else
            {
                string content = File.ReadAllText(storageFile);
                adults = JsonSerializer.Deserialize<List<Adult>>(content);
            }

            if (!File.Exists(userFile))
            {
                SeedUsers();
                WriteUsersToFile();
            }
            else
            {
                string content = File.ReadAllText(userFile);
                users = JsonSerializer.Deserialize<List<User>>(content);
            }
        }

        public void SeedUsers()
        {
            User[] users =
            {
                new User
                {
                    userName = "admin",
                    password = "admin"
                },
                new User
                {
                    userName = "test",
                    password = "123",
               
                }
            };
            this.users = users.ToList();
        }
        
        
        public async Task<List<Adult>> GetAdultsAsync()
        {
            return adults;
        }

        public async Task<ActionResult<Adult>> AddAdult (Adult adult)
        {
            adults.Add(adult);
            WriteAdultsToFile();
            return null;
        }

        public bool Delete(int id)
        {
            bool boolie=false;
            for (int i = 0; i < adults.Count; i++)
            {
                if (adults[i].Id == id)
                {
                    adults.RemoveAt(i);
                    boolie = true;
                }
                else boolie = false;
                WriteAdultsToFile();
            }

            return boolie;
        }

        private void WriteAdultsToFile()
        {
            string productsAsJson = JsonSerializer.Serialize(adults);
            File.WriteAllText(storageFile,productsAsJson);
        }

        private void WriteUsersToFile()
        {
            string producstsAsJson = JsonSerializer.Serialize(users);
            File.WriteAllText(userFile,producstsAsJson);
        }
        private void Seed()
        {
            Adult[] adults =
            {
                new Adult
                {
                    Id = 1,
                    Age = 20,
                    EyeColor = "Green",
                    FirstName = "bob",
                    HairColor = "Black",
                    Height = 123,
                    Weight = 299,
                    JobTitle = "jobmuch",
                    LastName = "boom",
                    Sex = "M"
                },
                new Adult
                {
                    Id = 2,
                    Age = 20,
                    EyeColor = "Green",
                    FirstName = "bob",
                    HairColor = "Black",
                    Height = 123,
                    Weight = 299,
                    JobTitle = "jobmuch",
                    LastName = "boom",
                    Sex = "M"
                }
            };
            this.adults = adults.ToList();
        }

        public async Task<List<User>> GetUsers()
        {
            return users;
        }

        public async Task<User> RegisterUser(string username,string password)
        {
            User tmpUser = new User {userName = username, password = password};
            users.Add(tmpUser);
            WriteUsersToFile();
            return null;
        }
    }
}