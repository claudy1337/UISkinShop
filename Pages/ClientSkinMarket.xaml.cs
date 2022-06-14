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

namespace WPFModernVerticalMenu.Pages
{
    /// <summary>
    /// Логика взаимодействия для ClientSkinMarket.xaml
    /// </summary>
    public partial class ClientSkinMarket : Page
    {
        public static Data.Classes.Client Clients;
        public ClientSkinMarket(Data.Classes.Client client)
        {
            Clients = client;
            InitializeComponent();
            listSkin.ItemsSource = Data.Classes.BD_Connection.bd.Skin.Where(s => s.Status == true && s.Client.ClientInformation.Login !=Clients.Login).ToList();
        }
    }
}
