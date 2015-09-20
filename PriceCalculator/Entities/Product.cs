using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PriceCalcutor.Entities
{
    public class Product
    {
        public string ProductName { get; set; }
        public double TotalRate { get; set; }
        public double BaseRate { get; set; }
        public string Discount { get; set; }
    }
}
