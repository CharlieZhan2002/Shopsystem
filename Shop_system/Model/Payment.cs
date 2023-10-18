using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop_system.Model
{
    public class Payment
    {
        public int PaymentId { get; set; }
        public string CardName { get; set; }
        public long CardNum { get; set; }
        public int CVV { get; set; }
        public string ExpiryMonth { get; set; }
        public string ExpiryYear { get; set; }

        // Foreign key
        public int UserId { get; set; }

    }
}
