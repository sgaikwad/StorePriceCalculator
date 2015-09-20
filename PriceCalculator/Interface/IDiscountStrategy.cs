using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PriceCalcutor.Entities;

namespace PriceCalcutor
{
    public interface IDiscountStrategy
    {
        List<Product> GetDiscount(string discountItems);
    }
}
