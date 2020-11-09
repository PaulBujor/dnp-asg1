using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Diagnostics;
using Models;

namespace FamilyTreeWebAP.Data
{
    public class FileStorage: IFileStorage
    {
        private string storageFile = "adults.json";
        private List<Adult> adults;
        

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

        private void WriteAdultsToFile()
        {
            string productsAsJson = JsonSerializer.Serialize(adults);
            File.WriteAllText(storageFile,productsAsJson);
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
    }
}