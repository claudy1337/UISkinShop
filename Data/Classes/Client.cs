using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFModernVerticalMenu.Data.Classes
{
    public class Client
    {
        public Client(string login, string name)
        {
            Login = login;
            Name = name;
        }
        public string Name { get; set; } 
        public string Login { get; set; } 
    }
}
