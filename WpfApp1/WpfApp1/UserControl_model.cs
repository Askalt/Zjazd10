using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WpfApp1
{
    public class UserControl_model
    {
        public ICommand RegisterCommand { get; set; }
        public Registration_model model { get; set; }
        public UserControl_model()
        {
            RegisterCommand = new Register_command();
            model = new Registration_model();
        }
    }
}
