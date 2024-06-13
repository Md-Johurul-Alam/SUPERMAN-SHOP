using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SupermanShop.Models
{
    public class CustomerPayment
    {
        public string CustomerName { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public int PhoneNumber { get; set; }
    }
}