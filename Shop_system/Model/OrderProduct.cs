using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop_system.Model
{
    public class OrderProduct
    {
        public int ProductId { get; set; }
        public Product Product { get; set; }

        public int OrderId { get; set; }
        public Order Order { get; set; }

        public int UserId {  get; set; }
        public User User { get; set; }

        public override int GetHashCode()
        {
            return OrderId.GetHashCode() ^ ProductId.GetHashCode() ^ UserId.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            if (!(obj is OrderProduct other))
                return false;

            return OrderId == other.OrderId && ProductId == other.ProductId && UserId == other.UserId;
        }
    }
}
