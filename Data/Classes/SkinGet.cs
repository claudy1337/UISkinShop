using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFModernVerticalMenu.Data.Classes
{
    public class SkinGet
    {
        public SkinGet(string market_name, string market_price, string clientLogin)
        {

            Market_Name = market_name;
            Market_Price = market_price;
            ClientLogin = clientLogin;
        }
        public static string Market_Name { get; set; }
        public static string Market_Price { get; set; }
        public static string ClientLogin { get; set; }
    }
}
