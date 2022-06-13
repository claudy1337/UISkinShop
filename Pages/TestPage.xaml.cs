using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Net;
using System.IO;
using Newtonsoft.Json.Bson;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json;
using WPFModernVerticalMenu.Data.Classes;

namespace WPFModernVerticalMenu.Pages
{
    /// <summary>
    /// Логика взаимодействия для TestPage.xaml
    /// </summary>
    public partial class TestPage : Page
    {
        public TestPage()
        {
            InitializeComponent();
            GetList();
        }
        public void GetList()
        {
            string urlPrice = "https://market.csgo.com/api/v2/prices/RUB.json";
           // string urlPrice = "http://csgobackpack.net/api/GetItemsList/v2/";
           
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(urlPrice);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            Stream stream = response.GetResponseStream();
            StreamReader sr = new StreamReader(stream);
            string sReadData = sr.ReadToEnd();
            response.Close();
            

            dynamic data = JsonConvert.DeserializeObject(sReadData);
            var skin = JsonConvert.DeserializeObject<SkinShortly.Rootobject>(data.ToString());
            string name;
            aboba.ItemsSource = skin.items;
            //foreach (var item in skin.items)
            //{
            //    name = item.market_hash_name;
            //    string urlInfo = "http://csgobackpack.net/api/GetItemPrice/?currency=USD&id=" + name + "&time=7&icon=1";
            //    HttpWebRequest requests = (HttpWebRequest)WebRequest.Create(urlInfo);
            //    HttpWebResponse responses = (HttpWebResponse)requests.GetResponse();
            //    Stream streams = responses.GetResponseStream();
            //    StreamReader srs = new StreamReader(streams);
            //    string sReadDatas = srs.ReadToEnd();
            //    response.Close();


            //    dynamic datas = JsonConvert.DeserializeObject(sReadDatas);
            //    var skins = JsonConvert.DeserializeObject<SkinCertain.Rootobject>(datas.ToString());
            //}
            
        }
    }
}
