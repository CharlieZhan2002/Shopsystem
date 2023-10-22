using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop_system.Model
{
    internal class Admin : User
    {
        // Constructor
        public Admin()
        {
            Role = UserRole.Admin;
        }

        // Any additional properties or methods specific to Admins would go here
    }
}
