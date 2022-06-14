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
using System.Text.RegularExpressions;
namespace WPFModernVerticalMenu.Pages

{
    /// <summary>
    /// Логика взаимодействия для BalanceRefill.xaml
    /// </summary>
    public partial class BalanceRefill : Page
    {
        public static Data.Classes.Client Client;
        public BalanceRefill(Data.Classes.Client client)
        {
            InitializeComponent();
            Client = client;
            txtSummAccount.CommandBindings.Add(new CommandBinding(ApplicationCommands.Paste, OnPasteCommand));
            txtPassword.CommandBindings.Add(new CommandBinding(ApplicationCommands.Paste, OnPasteCommand));
            var clients = BD_Connection.bd.Client.Where(c=>c.ClientInformation.Login == Client.Login).FirstOrDefault();
            txtClientName.Text = clients.ClientInformation.Name;
            txtBalance.Text = clients.ClientInformation.Balance.ToString();
        }

        private void BalanceRefil_Click(object sender, RoutedEventArgs e)
        {
            try
            {


                if (Client.Login != null)
                {
                    var client = Data.Classes.BD_Connection.bd.Client.Where(c => c.ClientInformation.Login == Client.Login && c.ClientInformation.Password == txtPassword.Password).FirstOrDefault();
                    if (client != null)
                    {
                        client.ClientInformation.Balance += Convert.ToDecimal(txtSummAccount.Text);
                        Client.Balance = client.ClientInformation.Balance.ToString();
                        BD_Connection.bd.SaveChanges();
                        MessageBox.Show("balance add: " + txtSummAccount.Text);
                        Refresh();
                    }
                }
                else if (string.IsNullOrWhiteSpace(txtBalance.Text) || string.IsNullOrWhiteSpace(txtPassword.Password))
                {
                    MessageBox.Show("incorrect");
                }
            }
            catch(Exception ex)
            {
                return;
            }
        }

        private void summ(object sender, TextCompositionEventArgs e)
        {
            if (!Char.IsDigit(e.Text, 0))
            {
                e.Handled = true;
            }
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }
        public void Refresh()
        {
            txtBalance.Text = null;
            txtSummAccount.Text = null;
            txtPassword.Password = null;
            var client = Data.Classes.BD_Connection.bd.Client.Where(c => c.ClientInformation.Login == Client.Login).FirstOrDefault();
            txtBalance.Text = client.ClientInformation.Balance.ToString();
        }
        public void OnPasteCommand(object sender, ExecutedRoutedEventArgs e)
        {

        }
        private void password(object sender, StylusEventArgs e)
        {

        }
    }
}
