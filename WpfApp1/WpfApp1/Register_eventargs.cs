using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    public class Register_eventargs
    {
        /*
        public Register_eventargs(string login, string password, string r_password, bool accept,bool oi_info)
        {
            this.login = login;
            this.password = password;
            this.r_password = r_password;
            this.accept = accept;
            this.oi_info = oi_info;
        }
        */
        public Register_eventargs(string login, string password, string r_password, bool accept, bool oi_info,string oi_info1, string oi_info2)
        {
            this.login = login;
            this.password = password;
            this.r_password = r_password;
            this.accept = accept;
            this.oi_info = oi_info;
            this.oi_info1 = oi_info1;
            this.oi_info2 = oi_info2;
        }
        public bool accept { get; set; }
        public bool oi_info { get; set; }
        public string login { get; set; }
        public string password { get; set; }
        public string r_password { get; set; }
        public string oi_info1 { get; set; }
        public string oi_info2 { get; set; }

    }
}
