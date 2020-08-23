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
            private string _login;
            private string _password;
            private string _rpassword;
        public Registration_model()
        {
        }
        public Registration_model(string login, string password, string r_password, bool accept)
            {
                this.login = login;
                this.password = password;
                this.r_password = r_password;
                this.accept = accept;
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
