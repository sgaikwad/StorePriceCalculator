using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PriceCalcutor
{
    public class SpecialDiscountStrategy: IDiscountStrategy
    {
        public string GetDiscount(string discountItems)
        {
            throw new NotImplementedException();
        }

        List<Entities.Product> IDiscountStrategy.GetDiscount(string discountItems)
        {
            throw new NotImplementedException();
        }
    }
}
