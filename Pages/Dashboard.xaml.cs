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
    /// Lógica de interacción para Dashboard.xaml
    /// </summary>
    public partial class Dashboard : Page
    {
        public Dashboard()
        {
            InitializeComponent();
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //string urlPrice = "https://market.csgo.com/api/v2/prices/RUB.json";


            string urlPrice = "http://csgobackpack.net/api/GetItemsList/v2/";
            //string informationUrl = "http://csgobackpack.net/api/GetItemPrice/?currency=USD&id=NAME&time=7&icon=1";

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(urlPrice);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            Stream stream = response.GetResponseStream();
            StreamReader sr = new StreamReader(stream);
            string sReadData = sr.ReadToEnd();
            response.Close();

            dynamic data = JsonConvert.DeserializeObject(sReadData);
            test.Text = data.ToString();
            //var skin = JsonConvert.DeserializeObject<SkinShortly.Rootobject>(test.Text);
            //foreach (var item in skin.items)
            //{
            //    aboba.ItemsSource = item.ToString();
            //}
        }
    }
}
