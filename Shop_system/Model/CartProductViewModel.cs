using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop_system.Model
{
    internal class CartProductViewModel
    {
        public int ProductId { get; set; }
        public int CartId { get; set; }
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        public int ProductQuantity { get; set; }
        public decimal ItemTotal { get; set; }
    }
}
