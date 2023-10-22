using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop_system.Model
{
    internal class Order
    {
        public enum OrderStatus
        {
            Cart, Paid, Shipped
        }
        public int OrderId { get; set; }
        public DateTime Date { get; set; }
        public int? PaymentId { get; set; }
        public OrderStatus Status { get; set; }
        public int UserId { get; set; }
        public ICollection<OrderProduct> OrderProducts { get; set; }


    }
}
