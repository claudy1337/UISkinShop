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
        public static Data.Classes.SkinGet SkinGets;
        public static Client Clients;
        public SkinInformation(Data.Classes.SkinGet skinGet, Client client)
        {
            InitializeComponent();
            SkinGets = skinGet;
            Clients = client;
            skinName.Text = SkinGets.Market_Name;
            skinPrice.Text = SkinGets.Market_Price;
            ClientName.Text = SkinGets.ClientName;
            ClientLogin.Text = SkinGets.ClientLogin;
            SkinGetInformation();
        }
        public void SkinGetInformation()
        {
            try
            {
                string url = "http://csgobackpack.net/api/GetItemPrice/?currency=USD&id=" + SkinGets.Market_Name + "&time=7&icon=1";
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                Stream stream = response.GetResponseStream();
                StreamReader sr = new StreamReader(stream);
                string sReadData = sr.ReadToEnd();
                response.Close();
                dynamic data = JsonConvert.DeserializeObject(sReadData);
                var skin = JsonConvert.DeserializeObject<SkinCertain.Rootobject>(data.ToString());
                SkinGets.ImgSkin = skin.icon;
                SkinGets.Currency = skin.currency;
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
            try
            {
                    Data.Model.Skin skin = new Data.Model.Skin
                    {
                        idClient = Clients.Id,
                        AveragePrice = AveragePrice.Text,
                        ImageUrl = SkinGets.ImgSkin,
                        LowestPrice = LowestPrice.Text,
                        Currency = SkinGets.Currency,
                        Price = SkinGets.Market_Price,
                        Status = false,
                        Name = SkinGets.Market_Name
                    };
                    Data.Model.Operation operation = new Data.Model.Operation
                    {
                        idSkin = skin.idSkin,
                        Date = DateTime.Now.Date,
                        TypeOperation = "buy skin"
                    };
                    var clientBalance = Data.Classes.BD_Connection.bd.Client.Where(c=>c.ClientInformation.Login == Clients.Login).FirstOrDefault();
                    var client = Data.Classes.BD_Connection.bd.Client.Where(c => c.ClientInformation.Login == SkinGets.ClientLogin).FirstOrDefault();
                    if (client != null)
                    {
                        client.ClientInformation.Balance += decimal.Parse(skinPrice.Text, System.Globalization.CultureInfo.InvariantCulture);
                        
                    }
                    clientBalance.ClientInformation.Balance -= decimal.Parse(skinPrice.Text, System.Globalization.CultureInfo.InvariantCulture);
                    BD_Connection.bd.Skin.Add(skin);
                    BD_Connection.bd.Operation.Add(operation);
                    BD_Connection.bd.SaveChanges();
                    MessageBox.Show("buying " + SkinGets.Market_Name);
            }
            catch(Exception)
            {
                return;
            }
}
    }
}
