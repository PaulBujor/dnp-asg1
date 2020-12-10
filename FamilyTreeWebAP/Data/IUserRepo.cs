using System.Threading.Tasks;
using FamilyTreeWebAP.Data.Models;

namespace FamilyTreeWebAP.Data
{
    public interface IUserRepo
    {
        Task<User> CreateUserAsync(User user);
    }
}