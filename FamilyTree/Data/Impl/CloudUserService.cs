using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using FamilyTree.Data.Models;
using Models;

namespace FamilyTree.Data.Impl
{
    public class CloudUserService : IUserService
    {
        public async Task<User> ValidateUser(string userName, string password)
        {


            User response = new User { userName = "", password = "" };

            try
            {
                HttpClient client = new HttpClient();
                string message = await client.GetStringAsync($"http://localhost:8081/{userName}/{password}");
                response = JsonSerializer.Deserialize<User>(message);
                Console.WriteLine(message);
                Console.WriteLine(response.userName);
                Console.WriteLine(response.password);
            }
            catch (HttpRequestException e)
            {
                throw new Exception();
            }

            Console.WriteLine(response.password);
            Console.WriteLine(response.userName);
            return response;



        }

        public async void ValidateNewUser(string userName, string password)
        {
            User tmpUser = new User { userName = userName, password = password };
            try
            {
                HttpClient client = new HttpClient();
                string adultSerialized = JsonSerializer.Serialize(tmpUser);
                StringContent content = new StringContent(adultSerialized, Encoding.UTF8, "application/json");
                HttpResponseMessage responseMessage =
                    await client.PostAsync($"http://localhost:8081/{userName}/{password}", content);
                Console.WriteLine(responseMessage);
            }
            catch (HttpRequestException e)
            {
                Console.WriteLine(e);
            }
        }
    }
}