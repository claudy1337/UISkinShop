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
using System.Text.RegularExpressions;
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
            txtDate.CommandBindings.Add(new CommandBinding(ApplicationCommands.Paste, OnPasteCommand));
            txtMaxPrice.CommandBindings.Add(new CommandBinding(ApplicationCommands.Paste, OnPasteCommand));
            txtMinPrice.CommandBindings.Add(new CommandBinding(ApplicationCommands.Paste, OnPasteCommand));
            txtPrice.CommandBindings.Add(new CommandBinding(ApplicationCommands.Paste, OnPasteCommand));
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
            if (skin.Status == false)  txtStatusSell.Text = "Not Sell";
            else if (skin.Status == true) txtStatusSell.Text = "Sell";

        }

        private void BtnSell_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double minPrice = double.Parse(txtMinPrice.Text, System.Globalization.CultureInfo.InvariantCulture);
                double maxPrice = double.Parse(txtMaxPrice.Text, System.Globalization.CultureInfo.InvariantCulture);
                double Price = double.Parse(txtPrice.Text, System.Globalization.CultureInfo.InvariantCulture);
                var skin = ListSkin.SelectedItem as Data.Model.Skin;
                Data.Model.Operation operation = new Data.Model.Operation
                {
                    idSkin = skin.idSkin,
                    Date = DateTime.Now.Date,
                    TypeOperation = "sell skin"
                };
                Data.Model.Skin Sellskins = Data.Classes.BD_Connection.bd.Skin.FirstOrDefault(s => s.idSkin == skin.idSkin && s.idClient == Clients.Id);
                if (Sellskins != null && minPrice <= Price && Price <= maxPrice && Sellskins.Status == false)
                {
                    Sellskins.Status = true;
                    Sellskins.Price = txtPrice.Text;

                }
                else
                {
                    MessageBox.Show("error");
                    return;
                }
                txtStatusSell.Text = "Sell";
                BD_Connection.bd.Operation.Add(operation);
                BD_Connection.bd.SaveChanges();
                MessageBox.Show("skin sell waiting buying");
                Refresh();
            }
            catch(Exception)
            {
                return;
            }
        }
        public void Refresh()
        {
            txtDate.Text = null;
            txtMaxPrice.Text = null;
            txtMinPrice.Text = null;
            txtPrice.Text = null;
        }
        private void price(object sender, TextCompositionEventArgs e)
        {
            if (!Char.IsDigit(e.Text, 0))
            {
                e.Handled = true;
            }
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }
        public void OnPasteCommand(object sender, ExecutedRoutedEventArgs e)
        {

        }
    }
}
