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
    /// Логика взаимодействия для HistoryPage.xaml
    /// </summary>
    public partial class HistoryPage : Page
    {
        public static Data.Classes.Client Client;
        public HistoryPage(Data.Classes.Client client)
        {
            Client = client;
            InitializeComponent();
            if (client.Role == 1 || client.Role == 3) DGHistory.ItemsSource = Data.Classes.BD_Connection.bd.Operation.ToList();
                
            else
            {
                DGHistory.ItemsSource = Data.Classes.BD_Connection.bd.Operation.Where(c => c.Skin.Client.ClientInformation.Login == client.Login).ToList();
                BtnSearch.Visibility = Visibility.Hidden;
                TxtSearch.Visibility = Visibility.Hidden;

            } 

        }

        private void BtnSearch_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                DGHistory.ItemsSource = Data.Classes.BD_Connection.bd.Operation.Where(h => h.Skin.Client.ClientInformation.Login == TxtSearch.Text || h.Skin.Price == TxtSearch.Text 
                || h.TypeOperation == TxtSearch.Text || h.Skin.Status.ToString() == TxtSearch.Text).ToList();
                if (TxtSearch.Text == null) DGHistory.ItemsSource = Data.Classes.BD_Connection.bd.Operation.ToList();
            }
            catch(Exception)
            {
                return;
            }
        }
    }
}
