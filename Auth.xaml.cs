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


namespace WPFModernVerticalMenu
{
    /// <summary>
    /// Логика взаимодействия для Auth.xaml
    /// </summary>
    public partial class Auth : Window
    {
        public Auth()
        {
            InitializeComponent();
            TxtClienLogin.CommandBindings.Add(new CommandBinding(ApplicationCommands.Paste, OnPasteCommand));
            TxtClientPassword.CommandBindings.Add(new CommandBinding(ApplicationCommands.Paste, OnPasteCommand));
        }

        private void TextBlock_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Registration registration = new Registration();
            registration.Show();
            this.Close();
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
                this.DragMove();
        }

        private void BtnAuthAccount_Click(object sender, RoutedEventArgs e)
        {
            Data.Model.Client client = Data.Classes.BD_Connection.bd.Client.FirstOrDefault(c=>c.ClientInformation.Login == TxtClienLogin.Text && c.ClientInformation.Password == TxtClientPassword.Password);
            if (string.IsNullOrWhiteSpace(TxtClienLogin.Text) & string.IsNullOrWhiteSpace(TxtClientPassword.Password) || client == null)
            {
                MessageBox.Show("incorrect");
            }
            else if (client != null)
            {
                Data.Classes.Client clientSet = new Data.Classes.Client(client.ClientInformation.Login, client.ClientInformation.Name);
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
