using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFModernVerticalMenu.Data.Classes
{
    public class Skins
    {
        public class Rootobject
        {
            public bool success { get; set; }
            public string currency { get; set; }
            public int timestamp { get; set; }
            public Items_List items_list { get; set; }
        }

        public class Items_List
        {
            public Skin skin { get; set; }
        }

        public class Skin
        {
            public string name { get; set; }
            public int marketable { get; set; }
            public int tradable { get; set; }
            public string classid { get; set; }
            public string icon_url { get; set; }
            public object icon_url_large { get; set; }
            public object type { get; set; }
            public string rarity { get; set; }
            public string rarity_color { get; set; }
            public Price price { get; set; }
            public string first_sale_date { get; set; }
        }

        public class Price
        {
            public _24_Hours _24_hours { get; set; }
            public _7_Days _7_days { get; set; }
            public _30_Days _30_days { get; set; }
            public All_Time all_time { get; set; }
        }

        public class _24_Hours
        {
            public float average { get; set; }
            public float median { get; set; }
            public string sold { get; set; }
            public string standard_deviation { get; set; }
            public float lowest_price { get; set; }
            public float highest_price { get; set; }
        }

        public class _7_Days
        {
            public float average { get; set; }
            public float median { get; set; }
            public string sold { get; set; }
            public string standard_deviation { get; set; }
            public float lowest_price { get; set; }
            public float highest_price { get; set; }
        }

        public class _30_Days
        {
            public float average { get; set; }
            public float median { get; set; }
            public string sold { get; set; }
            public string standard_deviation { get; set; }
            public float lowest_price { get; set; }
            public float highest_price { get; set; }
        }

        public class All_Time
        {
            public float average { get; set; }
            public float median { get; set; }
            public string sold { get; set; }
            public string standard_deviation { get; set; }
            public float lowest_price { get; set; }
            public float highest_price { get; set; }
        }
    }
}


