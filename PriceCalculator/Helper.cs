using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PriceCalcutor
{
    public sealed class Helper
    {
        public static Dictionary<string, double> GetItemPriceList()
        {
            var itemPrice = new Dictionary<string, double>();
            var itemsList = ConfigurationManager.AppSettings["ItemPrice"].Split(new char[] { '|' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            if (itemsList.Count > 0)
            {
                foreach (var item in itemsList)
                {
                    var itemDetail = item.Split(new char[] { ':' }, StringSplitOptions.RemoveEmptyEntries);
                    if (itemDetail.Length > 0)
                    {
                        itemPrice.Add(itemDetail[0], Convert.ToDouble(itemDetail[1]));
                    }
                }
            }
            return itemPrice;
        }


        public static Dictionary<string, string> GetItemDiscount()
        {
            var itemDiscount = new Dictionary<string, string>();
            var itemsList = ConfigurationManager.AppSettings["ItemDiscount"].Split(new char[] { '|' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            if (itemsList.Count > 0)
            {
                foreach (var item in itemsList)
                {
                    var itemDetail = item.Split(new char[] { ':' }, StringSplitOptions.RemoveEmptyEntries);
                    if (itemDetail.Length > 0)
                    {
                        itemDiscount.Add(itemDetail[0], itemDetail[1]);
                    }
                }
            }
            return itemDiscount;
        }

        public static Dictionary<string, string> GetWeekDayDiscount()
        {
            var itemDiscount = new Dictionary<string, string>();
            var itemsList = ConfigurationManager.AppSettings["WeekDayDiscount"].Split(new char[] { '|' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            if (itemsList.Count > 0)
            {
                foreach (var item in itemsList)
                {
                    var itemDetail = item.Split(new char[] { ':' }, StringSplitOptions.RemoveEmptyEntries);
                    if (itemDetail.Length > 0)
                    {
                        itemDiscount.Add(itemDetail[0], itemDetail[1]);
                    }
                }
            }
            return itemDiscount;
        }
    }
}
