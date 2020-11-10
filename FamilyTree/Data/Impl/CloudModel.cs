using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Models;

namespace FamilyTree.Data.Impl
{
    public class CloudModel: IModel
    {
        public async Task AddAdult(Adult adult)
        {
            try
            {
                HttpClient client = new HttpClient();
                string adultSerialized = JsonSerializer.Serialize(adult);
                StringContent content = new StringContent(adultSerialized, Encoding.UTF8, "application/json");
                HttpResponseMessage responseMessage = await client.PostAsync("http://localhost:8081/api/adults/post", content);
                Console.WriteLine(responseMessage);
            }
            catch (HttpRequestException e)
            {
                Console.WriteLine(e);
            }
        }

        public async Task<IList<Adult>> GetAdults()
        {
            IList<Adult> response = new List<Adult>();
            try
            {
                HttpClient client = new HttpClient();
                /*http://localhost:8081/api/adults*/
                string message = await client.GetStringAsync("http://localhost:8081/api/adults");
                response = JsonSerializer.Deserialize<List<Adult>>(message);
            }
            catch (HttpRequestException e)
            {
                Console.WriteLine(e);
            }

            return response;
        }

        public Task<IList<Adult>> GetAdults(string searchCriteria)
        {
            throw new System.NotImplementedException();
        }
    }
}