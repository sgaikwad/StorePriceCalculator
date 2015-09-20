using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PriceCalcutor.Entities;

namespace PriceCalcutor
{
    public class DiscountContext
    {
        private readonly IDiscountStrategy _discountStrategy;

        public DiscountContext(IDiscountStrategy discountStrategy)
        {
            _discountStrategy = discountStrategy;
        }


        public List<Product> GetDiscount(string item)
        {
            return _discountStrategy.GetDiscount(item);
        }

    }
}
