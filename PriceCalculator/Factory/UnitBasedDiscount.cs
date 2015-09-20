using System;
using PriceCalcutor.Entities;

namespace PriceCalcutor
{
    public class UnitBasedDiscount : IPriceDiscountFactory
    {
        public Product CalculatePrice(string item, string discountValue)
        {
            var items = Helper.GetItemPriceList();
            double itemPrice;
            Product product = null;
            if (items.TryGetValue(item, out itemPrice))
            {
                product = new Product
                {
                    ProductName = item,
                    TotalRate = itemPrice,
                    Discount = discountValue,
                    BaseRate = itemPrice
                };
            }
            return product;
        }
    }
}
