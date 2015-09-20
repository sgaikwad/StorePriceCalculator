using System;
using System.Collections.Generic;
using System.Linq;
using PriceCalcutor.Entities;
using PriceCalcutor.Factory;

namespace PriceCalcutor
{
    public class ItemLevelDiscountStrategy : IDiscountStrategy
    {
        public List<Product> GetDiscount(string discountItems)
        {
            var products = new List<Product>();
            var itemList = discountItems.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            var discountList = Helper.GetItemDiscount();
            Product product = null;
            foreach (var item in itemList)
            {
                string discountValue;
                if (discountList.TryGetValue(item, out discountValue))
                {
                    int configuredPrice;
                    int.TryParse(discountValue, out configuredPrice);
                    if (configuredPrice > 0)
                    {
                        var factory = DiscountFactory.GetDiscountFactory("FlatDiscount");
                        product = factory.CalculatePrice(item.ToLower(), discountValue);
                    }
                    else
                    {
                        var factory = DiscountFactory.GetDiscountFactory("UnitBasedDiscount");
                        product = factory.CalculatePrice(item.ToLower(), discountValue);
                    }
                }
                products.Add(product);
            }
            return products;
        }


    }
}
