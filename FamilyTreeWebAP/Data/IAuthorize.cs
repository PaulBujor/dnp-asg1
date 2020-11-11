using System.Threading.Tasks;
using FamilyTree.Data.Models;

namespace FamilyTreeWebAP.Data
{
    public interface IAuthorize
    {
        Task<User> ValidateUser(string username,string password);
        Task RegisterUser(string username,string password);
    }
}