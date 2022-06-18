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
using WPFModernVerticalMenu.Data.Classes;

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
            GetList();
            
        }
        public void GetList()
        {
            listSkin.ItemsSource = Data.Classes.BD_Connection.bd.Skin.Where(s => s.Status == true && s.Client.ClientInformation.Login != Clients.Login && s.SkinSold == false).ToList();
            
        }
        private void listSkin_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                var skin = listSkin.SelectedItem as Data.Model.Skin;
                SkinGet skinget = new SkinGet(skin.Name, skin.Price, skin.Client.ClientInformation.Login, skin.Client.ClientInformation.Name, null, skin.ImageUrl, skin.Currency);
                NavigationService.Navigate(new SkinInformation(skinget, Clients));
            }
            catch (Exception)
            {
                
            }
        }

       

        private void txtPrice_TextChanged(object sender, TextChangedEventArgs e)
        {
            
            listSkin.ItemsSource = Data.Classes.BD_Connection.bd.Skin.Where(s => s.Price == txtPrice.Text && s.Status == true && s.Client.ClientInformation.Login != Clients.Login && s.SkinSold == false).ToList();
        }

        private void BtnSearch_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(txtPrice.Text))
            {
                GetList();
            }
            else
            {
                listSkin.ItemsSource = Data.Classes.BD_Connection.bd.Skin.Where(s => s.Status == true && s.Price == txtPrice.Text && s.Currency == CBCurrency.Text && s.Client.ClientInformation.Login != Clients.Login && s.SkinSold == false).ToList();
            }
        }
    }
}
