using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PriceCalcutor.Entities;

namespace PriceCalcutor
{
    public class FlatDiscount : IPriceDiscountFactory
    {
        public Entities.Product CalculatePrice(string item, string discountValue)
        {
            var items = Helper.GetItemPriceList();
            double itemPrice;
            Product product = null;
            if (items.TryGetValue(item, out itemPrice))
            {
                int val = Convert.ToInt32(discountValue);
                double discountedPrice = (itemPrice/100)*val;
                double totalPrice = itemPrice - discountedPrice;

                product = new Product
                {
                    ProductName = item,
                    TotalRate = totalPrice,
                    Discount = discountValue,
                    BaseRate = itemPrice
                };
            }
            return product;
        }
    }
}
