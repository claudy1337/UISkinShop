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
using System.Windows.Shapes;
using WPFModernVerticalMenu.Data.Classes;
using WPFModernVerticalMenu.Data;



namespace WPFModernVerticalMenu
{
    /// <summary>
    /// Логика взаимодействия для Registration.xaml
    /// </summary>
    public partial class Registration : Window
    {
        public Registration()
        {
            InitializeComponent();
            TxtClientLogin.CommandBindings.Add(new CommandBinding(ApplicationCommands.Paste, OnPasteCommand));
            TxtClientName.CommandBindings.Add(new CommandBinding(ApplicationCommands.Paste, OnPasteCommand));
            TxtClientPassword.CommandBindings.Add(new CommandBinding(ApplicationCommands.Paste, OnPasteCommand));
        }

        private void TextBlock_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Auth auth = new Auth();
            auth.Show();
            this.Close();
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
                this.DragMove();
        }

        private void BtnCreateAccount_Click(object sender, RoutedEventArgs e)
        {
            Data.Model.Client clients = Data.Classes.BD_Connection.bd.Client.FirstOrDefault(c=>c.IdRole == 1 || c.ClientInformation.Login == TxtClientLogin.Text);
            if (string.IsNullOrWhiteSpace(TxtClientLogin.Text) && string.IsNullOrWhiteSpace(TxtClientName.Text) && string.IsNullOrWhiteSpace(TxtClientPassword.Password) || clients != null)
            {
                MessageBox.Show("incorrect");
            }
            else if(clients == null)
            {   
                Data.Model.ClientInformation clientInformation = new Data.Model.ClientInformation
                {
                    Name = TxtClientName.Text,
                    Login = TxtClientLogin.Text,
                    Balance = 0,
                    Password = TxtClientPassword.Password
                };
                BD_Connection.bd.ClientInformation.Add(clientInformation);
                Data.Model.Client client = new Data.Model.Client
                {
                    idClientInformation = clientInformation.idClientInformation,
                    IdRole = 2
                };
                BD_Connection.bd.Client.Add(client);
                BD_Connection.bd.SaveChanges();
                Data.Classes.Client clientSet = new Client(clientInformation.Login, clientInformation.Name);
                MessageBox.Show("welcome " + client.ClientInformation.Name);
                MainWindow main = new MainWindow(clientSet);
                main.Show();
                this.Close();
            }
        }
        public void OnPasteCommand(object sender, ExecutedRoutedEventArgs e)
        {

        }
    }
}
