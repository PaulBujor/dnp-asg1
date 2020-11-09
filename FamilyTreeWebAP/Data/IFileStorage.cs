using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Models;

namespace FamilyTreeWebAP.Data
{
    public interface IFileStorage
    {
        Task<List<Adult>> GetAdultsAsync();
        Task<ActionResult<Adult>> AddAdult(Adult adult);
    }
}