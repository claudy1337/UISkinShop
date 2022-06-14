using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFModernVerticalMenu.Data.Classes
{
    public class Client
    {
        public Client(string login, string name, int role, decimal balance, string link)
        {
            Login = login;
            Name = name;
            Role = role;
            Balance = balance;
            Link = link;
            
        }
        public string Name { get; set; }
        public string Login { get; set; }
        public int Role { get; set; }
        public decimal Balance { get; set; }
        public string Link { get; set; }
    }
}
