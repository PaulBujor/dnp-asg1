﻿using FamilyTree.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FamilyTree.Data
{
        public interface IUserService
        {
            Task<User> ValidateUser(string userName, string password);

            void ValidateNewUser(string userName, string password);
    }
    
}
