using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Models;

namespace FamilyTreeWebAP.Data.Impl
{
    public interface IAdultRepo
    {
        //create
        Task<Adult> CreateAdultAsync(Adult adult);

        //read
        Task<IList<Adult>> GetAllAdultsAsync();

        //update
        //Task UpdateAdult(Adult adult);

        //Delete
        //Task DeleteQueen();

        Task DeleteAdultAsync(int id);
    }
}