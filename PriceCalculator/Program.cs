using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PriceCalcutor.Context;
using PriceCalcutor.Strategies;

namespace PriceCalcutor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Item to be purschased(comma separated): ");
            string name = Console.ReadLine();

            if (string.IsNullOrEmpty(name) == false)
            {
                var discountContext = new DiscountContext(new ItemLevelDiscountStrategy());
                var products = discountContext.GetDiscount(name);
                var totalBillAmount = GetTotalBillAmount(products);
                var specialDiscountContext = new SpecialDiscountContext(new WeekDayDiscountStrategy());
                var totalAmount = specialDiscountContext.GetTotalAmount(totalBillAmount);
                DispalyBill(totalAmount, totalBillAmount);
            }
            else
            {
                Console.WriteLine("Please enter valid items");
                Console.ReadLine();
            }
        }

        private static void DispalyBill(double totalAmount, double totalBillAmount)
        {
            string billDate = string.Format("{0}:{1}", "Bill Date", DateTime.Now.ToString("yyyy-MM-dd"));
            Console.WriteLine(billDate);
            string resultTotalAmount = string.Format("{0}:{1}", "Total Bill Amount", totalAmount);
            Console.WriteLine(resultTotalAmount);
            string resultTotalDiscountAmount = string.Format("{0}:{1}", "Total Amount Saved", totalBillAmount - totalAmount);
            Console.WriteLine(resultTotalDiscountAmount);
            Console.ReadLine();
        }

        private static double GetTotalBillAmount(List<Entities.Product> products)
        {
            if (products != null && products.Count > 0)
            {
                return products.Sum(x => x != null ? x.TotalRate : 0);
            }
            return 0;
        }
    }
}
