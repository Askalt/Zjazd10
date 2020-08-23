using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    public class Register_eventargs
    {
        public Register_eventargs(string login, string password, string r_password, bool accept)
        {
            this.login = login;
            this.password = password;
            this.r_password = r_password;
            this.accept = accept;
        }
        public bool accept { get; set; }
        public string login { get; set; }
        public string password { get; set; }
        public string r_password { get; set; }

    }
}
