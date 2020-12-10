using System.Threading.Tasks;
using FamilyTreeWebAP.Data.Models;

namespace FamilyTreeWebAP.Data
{
    public interface IAuthorize
    {
        Task<User> ValidateUser(string username,string password);
        Task RegisterUser(string username,string password);
    }
}