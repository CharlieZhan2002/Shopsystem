using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop_system
{
    public class Customer : User
    {
        // Constructor
        public Customer()
        {
            this.Role = UserRole.Customer;
        }

        // Any additional properties or methods specific to Customers would go here
    }
}
