using System.Threading.Tasks;
using FamilyTreeWebAP.Data.Models;
using FamilyTreeWebAP.DataAccess;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace FamilyTreeWebAP.Data.Impl
{
    public class UserRepoImpl : IUserRepo
    {
        private AdultDbContext DbContext;

        public UserRepoImpl()
        {
            DbContext = new AdultDbContext();
        }

        public async Task<User> CreateUserAsync(User user)
        {
            EntityEntry<User> newlyAdded = await DbContext.AddAsync(user);
            await DbContext.SaveChangesAsync();
            return newlyAdded.Entity;
        }
    }
}