﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop_system.Model
{
    public enum UserRole
    {
        Admin,
        User,
        Customer
    }

    public class User
    {
        public int UserId { get; set; }
        public string Username { get; set; }
        public string PasswordHash { get; set; }
        public UserRole Role { get; set; }
        public string Email { get; set; }
        public string ShippingAddress { get; set; }
        public ICollection<OrderProduct> OrderProducts { get; set; }
    }
}