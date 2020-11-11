using System.Collections.Generic;
using System.Threading.Tasks;
using FamilyTree.Data.Models;
using Microsoft.AspNetCore.Mvc;
using Models;

namespace FamilyTreeWebAP.Data
{
    public interface IFileStorage
    {
        Task<List<Adult>> GetAdultsAsync();
        Task<ActionResult<Adult>> AddAdult(Adult adult);
        Task<List<User>> GetUsers();
        Task<User> RegisterUser(string username,string password);

       bool Delete(int id);
    }
}