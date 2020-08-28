using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    public class Registration_model : INotifyPropertyChanged
        {
            public bool accept { get; set; }
            public bool oi_info { get; set; }
            private string _login;
            private string _password;
            private string _rpassword;
            private string _oiinfo1;
            private string _oiinfo2;


        public Registration_model()
        {
        }
        public Registration_model(string login, string password, string r_password, bool accept,bool oi_info,string oi_info1, string oi_info2)
            {
                this.login = login;
                this.password = password;
                this.r_password = r_password;
                this.accept = accept;
                this.oi_info = oi_info;
                this.oi_info1 = oi_info1;
                this.oi_info2 = oi_info2;

        }
            public string login
            {
                get => _login;
                set
                {
                    if (_login != value)
                    {
                        _login = value;
                        OnPropertyChanged("login");
                    }
                }
            }
            public string password
            {
                get => _password;
                set
                {
                    if (_password != value)
                    {
                        _password = value;
                        OnPropertyChanged("password");
                    }
                }
            }
            public string r_password
            {
                get => _rpassword;
                set
                {
                    if (_rpassword != value)
                    {
                        _rpassword = value;
                        OnPropertyChanged("r_password");
                    }
                }
            }
        public string oi_info1
        {
            get => _oiinfo1;
            set
            {
                if (_oiinfo1 != value)
                {
                    _oiinfo1 = value;
                    OnPropertyChanged("oi_info1");
                }
            }
        }
        public string oi_info2
        {
            get => _oiinfo2;
            set
            {
                if (_oiinfo2 != value)
                {
                    _oiinfo2 = value;
                    OnPropertyChanged("oi_info2");
                }
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;
            private void OnPropertyChanged(string property)
            {
                if (PropertyChanged != null)
                {
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
                }
            }
        }
}
