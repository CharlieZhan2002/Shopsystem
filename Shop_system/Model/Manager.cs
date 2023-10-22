using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop_system.Model
{
    internal class Manager : User
    {
        // Constructor
        public Manager()
        {
            Role = UserRole.Manager;
        }

        // Any additional properties or methods specific to Customers would go here
    }
}
