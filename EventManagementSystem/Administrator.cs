﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventManagementSystem
{
    public class Administrator : User
    {
        public Administrator()
        {
            Role = Role.Administrator;
        }
    }
}
