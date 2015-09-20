using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PriceCalcutor.Interface;

namespace PriceCalcutor.Context
{
    public class SpecialDiscountContext
    {
        private readonly ISpecialDiscountStrategy _specialDiscountStrategy = null;

        public SpecialDiscountContext(ISpecialDiscountStrategy specialDiscountStrategy)
        {
            _specialDiscountStrategy = specialDiscountStrategy;
        }

        public double GetTotalAmount(double totalBill)
        {
            return _specialDiscountStrategy.GetSpecialDiscountBill(totalBill);
        }
    }
}
