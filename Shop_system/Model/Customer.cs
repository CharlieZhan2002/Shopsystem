using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop_system.Model
{
    internal class Customer : User
    {
        // Constructor
        public Customer()
        {
            Role = UserRole.Customer;
        }
        // Any additional properties or methods specific to Customers would go here
        public string ShippingAddress { get; set; }

        public ICollection<OrderProduct> OrderProducts { get; set; }
    }
}
