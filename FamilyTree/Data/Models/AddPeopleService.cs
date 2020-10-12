using System.Collections.Generic;
using System.IO;
using System.Text.Json;


namespace Models
{
    public class AddPeopleService: IAddPeople
    
    {
        private string adultFile = "adults.json";
        private IList<Adult> adults;

        public AddPeopleService()
        {
            if (!File.Exists(adultFile))
            {
                string productsAsJson = JsonSerializer.Serialize(adults);
                File.WriteAllText(adultFile,productsAsJson);
            }
            else
            {
                string content = File.ReadAllText(adultFile);
                adults = JsonSerializer.Deserialize<List<Adult>>(content);
            }
        }


        public void addAdult(Adult adult)
        {
            adults.Add(adult);
            string productAsJson = JsonSerializer.Serialize(adults);
            File.WriteAllText(adultFile,productAsJson);
        }
    }
}