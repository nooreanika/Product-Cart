using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProductApp
{
    public class Product
    {
        public int PID { get; set; }
        public string BrandName { get; set; }
        public string PCatagory { get; set; }
        public string Details { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }
        public int NoOfIteam { get; set; }
        public string PType { get; set; }
    }
}