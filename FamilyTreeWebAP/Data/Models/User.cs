using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FamilyTreeWebAP.Data.Models
{
    public class User
    {
        [Key]
        public string userName { get; set; }
        [Required]
        public string password { get; set; }
    }
}
