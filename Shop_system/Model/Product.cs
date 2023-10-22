using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop_system.Model
{
    internal class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }

        // Foreign key for the product category
        public int CategoryId { get; set; }
        public virtual ProductCategory Category { get; set; }  // Navigation property for lazy loading of Entity Framework

        public ICollection<OrderProduct> OrderProducts { get; set; }

        public ICollection<CartProduct> CartProducts { get; set; }
    }
}
