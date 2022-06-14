using Microsoft.Win32;
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
using WPFModernVerticalMenu.Data.Model;

namespace WPFModernVerticalMenu.Pages
{
    /// <summary>
    /// Lógica de interacción para Home.xaml
    /// </summary>
    public partial class Home : Page
    {
        public static Data.Classes.Client Clients;
        public Home(Data.Classes.Client client)
        {
            Clients = client;
            InitializeComponent();
            txtClientName.Text = client.Name.ToString();
            txtClientLink.CommandBindings.Add(new CommandBinding(ApplicationCommands.Paste, OnPasteCommand));
            txtClientName.CommandBindings.Add(new CommandBinding(ApplicationCommands.Paste, OnPasteCommand));
            txtClientLogin.Text = client.Login.ToString();
            txtClientBalance.Text = client.Balance.ToString();
            txtClientLink.Text = client.Link.ToString();
        }

        private void BtnBalanceAdd_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new BalanceRefill(Clients));
        }
        private void BtnEditContetn_Click(object sender, RoutedEventArgs e)
        {
            var selectedClient = BD_Connection.bd.Client.Where(c => c.ClientInformation.Login == Clients.Login && c.ClientInformation.Login == txtClientLogin.Text).FirstOrDefault();
            selectedClient.ClientInformation.Name = txtClientName.Text;
            Clients.Name = selectedClient.ClientInformation.Name;
            Data.Model.Client clients = Data.Classes.BD_Connection.bd.Client.FirstOrDefault(c => c.ClientInformation.Link == txtClientLink.Text);
            if (clients == null)
            {
                selectedClient.ClientInformation.Link = txtClientLink.Text;
                Clients.Link = selectedClient.ClientInformation.Link;
                
            }
            BD_Connection.bd.SaveChanges();
            MessageBox.Show("client edit"); 
        }
        BitmapImage bitmapImage = new BitmapImage();
        private void Image_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.FilterIndex = 1;
            if (ofd.ShowDialog() == true)
            {
                
                bitmapImage.BeginInit();
                bitmapImage.UriSource = new Uri(ofd.FileName);
                bitmapImage.EndInit();
                imgClient.Source = bitmapImage;
            }
        }
        public void OnPasteCommand(object sender, ExecutedRoutedEventArgs e)
        {

        }
    }
}
