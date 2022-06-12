using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFModernVerticalMenu.Data.Classes
{
    public class SkinShortly
    {
        public class Rootobject
        {
            public bool success { get; set; }
            public int time { get; set; }
            public string currency { get; set; }
            public Item[] items { get; set; }
        }

        public class Item
        {
            public string market_hash_name { get; set; }
            public string volume { get; set; }
            public string price { get; set; }
        }
    }
}



