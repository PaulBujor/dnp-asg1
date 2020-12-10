using System.Threading.Tasks;
using FamilyTreeWebAP.Data.Models;
using Microsoft.EntityFrameworkCore;
using Models;

namespace FamilyTreeWebAP.DataAccess
{
    public class AdultDbContext : DbContext
    {
        public DbSet<Adult> Adults { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //name of database
            optionsBuilder.UseSqlite("Data Source = Adults.db");
        }
    }
}