using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop_system.Model
{
    public class Order
    {
        public int OrderId { get; set; }
        public DateTime Date { get; set; }
        public string ShippingAddress { get; set; }
        public string OrderStatus { get; set; }
        public int PaymentId { get; set; }
        public double Total {  get; set; }

    }
}
