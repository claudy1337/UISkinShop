using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFModernVerticalMenu.Data.Classes
{
    public class SkinGet
    {
        public SkinGet(string market_name, string market_price, string clientLogin, string clientName, string imgClient, string imgSkin, string currency)
        {

            Market_Name = market_name;
            Market_Price = market_price;
            ClientLogin = clientLogin;
            ClientName = clientName;
            ImgClient = imgClient;
            ImgSkin = imgSkin;
            Currency = currency;
        }
        public string Market_Name { get; set; }
        public string Market_Price { get; set; }
        public string ClientLogin { get; set; }
        public string ClientName { get; set; }
        public string ImgClient { get; set;}
        public string ImgSkin { get; set; }
        public string Currency {get; set;}
    }
}
