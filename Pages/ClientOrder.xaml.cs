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

namespace WPFModernVerticalMenu.Pages
{
    /// <summary>
    /// Логика взаимодействия для ClientOrder.xaml
    /// </summary>
    public partial class ClientOrder : Page
    {
        public static Data.Classes.Client Clients;
        public ClientOrder(Client client)
        {
            Clients = client;
            InitializeComponent();
            ListSkin.ItemsSource = Data.Classes.BD_Connection.bd.Skin.ToList().Where(s=>s.idClient == Clients.Id);
        }

        private void ListSkin_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var skin = ListSkin.SelectedItem as Data.Model.Skin;
            Data.Model.Operation operation = Data.Classes.BD_Connection.bd.Operation.FirstOrDefault(o=> o.idSkin == skin.idSkin);
            txtDate.Text = operation.Date.ToString();
            txtMaxPrice.Text = skin.AveragePrice.ToString();
            txtMinPrice.Text = skin.LowestPrice.ToString();
            txtPrice.Text = skin.Price.ToString();

        }

        private void BtnSell_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
