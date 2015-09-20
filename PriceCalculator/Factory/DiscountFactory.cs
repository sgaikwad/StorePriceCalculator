using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PriceCalcutor.Factory
{
    public class DiscountFactory
    {
        public static IPriceDiscountFactory GetDiscountFactory(string factoryName)
        {
            switch (factoryName)
            {
                case "UnitBasedDiscount":
                    return new UnitBasedDiscount();
                case "FlatDiscount":
                    return new FlatDiscount();
                default:
                    throw new Exception("Invalid DiscountType");
            }
        }
    }
}
