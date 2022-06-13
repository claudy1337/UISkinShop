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
            string urlPrice = "http://csgobackpack.net/api/GetItemPrice/?currency=USD&id=" + skinname.Text + "&time=7&icon=1";
            //  String urlimg = "http://cdn.steamcommunity.com/economy/image/-9a81dlWLwJ2UUGcVs_nsVtzdOEdtWwKGZZLQHTxDZ7I56KU0Zwwo4NUX4oFJZEHLbXH5ApeO4YmlhxYQknCRvCo04DEVlxkKgpot7HxfDhnwMzJemkV0966m4-PhOf7Ia_ummJW4NE_3rnHpdujjgK28kE5Y2Gid9WWdQ44YVHS-VS9wr--jJG6tJrAzCBh6D5iuyjdE47G3Q/";
          //  string urlPrice = "http://csgobackpack.net/api/GetItemsList/v2/";
            //string informationUrl = "http://csgobackpack.net/api/GetItemPrice/?currency=USD&id=NAME&time=7&icon=1";

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(urlPrice);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            Stream stream = response.GetResponseStream();
            StreamReader sr = new StreamReader(stream);
            string sReadData = sr.ReadToEnd();
            response.Close();

            dynamic data = JsonConvert.DeserializeObject(sReadData);
            test.Text = data.ToString();
            var skin = JsonConvert.DeserializeObject<SkinCertain.Rootobject>(test.Text);

            img.Source = new BitmapImage(new Uri(skin.icon, UriKind.RelativeOrAbsolute));
            //foreach (var item in skin.icon)
            //{
            //    img.Source = new BitmapImage(new Uri(item.icon, UriKind.RelativeOrAbsolute));
            //}




        }
    }
}
