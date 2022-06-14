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
using WPFModernVerticalMenu.Data;
using WPFModernVerticalMenu.Data.Classes;
using System.Net;
using System.IO;
using Newtonsoft.Json.Bson;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json;


namespace WPFModernVerticalMenu.Pages
{
    /// <summary>
    /// Логика взаимодействия для SkinInformation.xaml
    /// </summary>
    public partial class SkinInformation : Page
    {
        public static SkinGet SkinGet;
        public static Client Client;
        public SkinInformation(SkinGet skinGet, Client client)
        {
            InitializeComponent();
            SkinGet = skinGet;
            Client = client;
            skinName.Text = SkinGet.Market_Name;
            skinPrice.Text = SkinGet.Market_Price;
            SkinGetInformation();
        }
        public void SkinGetInformation()
        {
            try
            {
                string url = "http://csgobackpack.net/api/GetItemPrice/?currency=USD&id=" + SkinGet.Market_Name + "&time=7&icon=1";
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                Stream stream = response.GetResponseStream();
                StreamReader sr = new StreamReader(stream);
                string sReadData = sr.ReadToEnd();
                response.Close();

                dynamic data = JsonConvert.DeserializeObject(sReadData);
                var skin = JsonConvert.DeserializeObject<SkinCertain.Rootobject>(data.ToString());

                imgSkin.Source = new BitmapImage(new Uri(skin.icon, UriKind.RelativeOrAbsolute));
                AveragePrice.Text = skin.average_price;
                LowestPrice.Text = skin.lowest_price;
            }
            catch(System.ArgumentNullException ex)
            {
                MessageBox.Show("connect error");
                return;
            }
            
        }

        private void BtnSkinBuy_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
