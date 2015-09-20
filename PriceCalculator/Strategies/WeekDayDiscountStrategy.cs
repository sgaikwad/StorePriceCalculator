using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PriceCalcutor.Interface;

namespace PriceCalcutor.Strategies
{
    public class WeekDayDiscountStrategy : ISpecialDiscountStrategy
    {
        public double GetSpecialDiscountBill(double totalBillAmount)
        {
            var weekDayDiscountList = Helper.GetWeekDayDiscount();

            string weekDayDiscount;
            weekDayDiscountList.TryGetValue(DateTime.Now.DayOfWeek.ToString().ToLower(), out weekDayDiscount);

            int configuredPrice;
            int.TryParse(weekDayDiscount, out configuredPrice);
            double totalPrice;
            if (configuredPrice > 0)
            {
                double discountedPrice = (totalBillAmount / 100) * configuredPrice;
                totalPrice = totalBillAmount - discountedPrice;
            }
            else
            {
                totalPrice = totalBillAmount;
            }
            return totalPrice;
        }
    }
}
