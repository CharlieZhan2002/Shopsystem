using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop_system
{
    public class Admin : User
    {
        // Constructor
        public Admin()
        {
            this.Role = UserRole.Admin;
        }

        // Any additional properties or methods specific to Admins would go here
    }
}
