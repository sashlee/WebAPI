﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDataBase.Entity
{
    public class User
    {
        public string UserId { get; set; }
        public DateTime DateCreated { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Email { get; set;  }
        public string Password { get; set; }
    }
}
