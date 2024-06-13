using SupermanShop.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SupermanShop.Models.Home
{
    public class Item
    {
        public Tbl_Product Product { get; set; }
        public int Quantity { get; set; }
    }
}