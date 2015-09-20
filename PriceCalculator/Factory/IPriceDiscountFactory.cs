using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PriceCalcutor.Entities;

namespace PriceCalcutor
{
    public interface IPriceDiscountFactory
    {
        Product CalculatePrice(string item, string discountValue);
    }
}
