using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFModernVerticalMenu.Data.Classes
{
    public class Client
    {
        public Client(string login, string name, int role, string balance, string link, int id)
        {

            Login = login;
            Name = name;
            Role = role;
            Balance = balance;
            Link = link;
            Id = id;
        }
        public string Name { get; set; }
        public int Id { get; set; }
        public string Login { get; set; }
        public int Role { get; set; }
        public string Balance { get; set; }
        public string Link { get; set; }
    }
}
