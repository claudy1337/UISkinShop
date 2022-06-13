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
    /// Логика взаимодействия для Market.xaml
    /// </summary>
    public partial class Market : Page
    {
        
        public Market()
        {
            InitializeComponent();
            GetListSkin();
            searchcm
        }
        public void GetListSkin()
        {
            string urlPrice = "https://market.csgo.com/api/v2/prices/USD.json";
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(urlPrice);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            Stream stream = response.GetResponseStream();
            StreamReader sr = new StreamReader(stream);
            string sReadData = sr.ReadToEnd();
            response.Close();
            dynamic data = JsonConvert.DeserializeObject(sReadData);
            var skin = JsonConvert.DeserializeObject<SkinShortly.Rootobject>(data.ToString());
           
            listMarket.ItemsSource = skin.items;
        }

        private void listMarket_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var skin = listMarket.SelectedItem as SkinShortly.Item;
            SkinGet skinget = new SkinGet(skin.market_hash_name, skin.price, "CSGO-BackPack");
            NavigationService.Navigate(new SkinInformation(skinget));
        }

        private void BtnSearch_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
