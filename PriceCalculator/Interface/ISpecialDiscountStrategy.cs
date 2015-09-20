using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PriceCalcutor.Interface
{
    public interface ISpecialDiscountStrategy
    {
        double GetSpecialDiscountBill(double totalBillAmount);
    }
}
