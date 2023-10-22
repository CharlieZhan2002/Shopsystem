using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop_system.Model
{
    public class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string Category { get; set; } 

        public ICollection<OrderProduct> OrderProducts { get; set; }

        public ICollection<CartProduct> CartProducts { get; set; }
    }
}
 