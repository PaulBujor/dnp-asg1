using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FamilyTreeWebAP.DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Models;

namespace FamilyTreeWebAP.Data.Impl
{
    public class AdultRepoImpl : IAdultRepo
    {
        private AdultDbContext DbContext;

        public AdultRepoImpl()
        {
            DbContext = new AdultDbContext();
        }

        //Create
        /*async Task IAdultDBService.CreateAdult(Adult Adult)
        {
            Adult adulto = new Adult
            {
                Id = 99,
                FirstName = "Margrethe",
                LastName = "II",
                HairColor = "white",
                EyeColor = "blue",
                Age = 80,
                Weight = 60,
                Height = 170,
                Sex = "Female",
                JobTitle = "Queen of Denmark"
            };

            using (AdultDbContext dbContext = new AdultDbContext())
            {
                await dbContext.AddAsync(adulto);
                await dbContext.SaveChangesAsync();
            }
        }*/

        public async Task<Adult> CreateAdultAsync(Adult adult)
        {
            EntityEntry<Adult> newlyAdded = await DbContext.AddAsync(adult);
            await DbContext.SaveChangesAsync();
            return newlyAdded.Entity;
        }

        //Read 
        public async Task DeleteAdultAsync(int id)
        {
            Adult toDelete = await DbContext.Adults.FirstOrDefaultAsync(a => a.Id == id);
            if (toDelete != null)
            {
                DbContext.Adults.Remove(toDelete);
                await DbContext.SaveChangesAsync();
            }
        }

        async Task<IList<Adult>> IAdultRepo.GetAllAdultsAsync()
        {
            return await DbContext.Adults.ToListAsync();
        }

        //Update
        /*Task IAdultRepo.UpdateAdult(Adult adult)
        {
            throw new System.NotImplementedException();
        }*/

        //Delete
        /*async Task IAdultRepo.DeleteQueen()
        {
            using (AdultDbContext dbContext = new AdultDbContext())
            {
                IQueryable<Adult> result = dbContext.Adults.Where(a => a.Id == 99);
                Adult queen = await dbContext.Adults.FirstOrDefaultAsync(a => a.Id == 99);

                dbContext.Remove(queen);
                await dbContext.SaveChangesAsync();
            }
        }*/

        /*public Task DeleteAdult(Adult adult)
        {
            throw new NotImplementedException();
        }*/
    }
}