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
using WPFModernVerticalMenu.Data.Model;

namespace WPFModernVerticalMenu.Pages
{
    /// <summary>
    /// Логика взаимодействия для ClientControl.xaml
    /// </summary>
    public partial class ClientControl : Page
    {
        public static Data.Classes.Client Clients;
        public ClientControl(Data.Classes.Client client)
        {
            Clients = client;
            InitializeComponent();
            Refresh();
        }

        private void ClientList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var client = ClientList.SelectedItem as Data.Model.Client;
            try
            {
                    txtClientName.Text = client.ClientInformation.Name;
                    txtBlance.Text = client.ClientInformation.Balance.ToString();
                    txtClientLink.Text = client.ClientInformation.Link;
                    listSkin.ItemsSource = BD_Connection.bd.Skin.Where(s=>s.Client.idClient == client.idClient && s.Client.IdRole == 2).ToList();
            }
            catch (System.NullReferenceException)
            {
                Refresh();
                return;
            }
        }

        private void BtnEditClient_Click(object sender, RoutedEventArgs e)
        {
            var selectedClient = ClientList.SelectedItem as Data.Model.Client;
            if (selectedClient != null)
            {
                var clients = Data.Classes.BD_Connection.bd.Client.Where(c => c.ClientInformation.Login == selectedClient.ClientInformation.Login).FirstOrDefault();
                selectedClient.ClientInformation.Name = txtClientName.Text;
                selectedClient.ClientInformation.Link = txtClientLink.Text;
                BD_Connection.bd.SaveChanges();
                MessageBox.Show("client edit");
                Refresh();
            }
            else
                MessageBox.Show("incorrect");
        }
        public void Refresh()
        {
            
            txtClientLink.Text = null;
            txtBlance.Text = null;
            txtClientName.Text = null;
            ClientList.ItemsSource = null;
            ClientList.ItemsSource = Data.Classes.BD_Connection.bd.Client.Where(c=>c.IdRole == 2).ToList();
        }

        private void listSkin_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var skin = listSkin.SelectedItem as Data.Model.Skin;
            SkinGet skinGet = new SkinGet(skin.Name,skin.Price,skin.Client.ClientInformation.Login, skin.Client.ClientInformation.Name, null, skin.ImageUrl, skin.Currency);
            NavigationService.Navigate(new SkinInformation(skinGet, Clients));
        }
    }
}
