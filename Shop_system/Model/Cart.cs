﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop_system.Model
{
    internal class Cart
    {
        public int CartId { get; set; }
        public int UserId { get; set; }

        public ICollection<CartProduct> CartProducts { get; set; }
    }
}
