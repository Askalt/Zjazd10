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

namespace WpfApp1
{
    /// <summary>
    /// Logika interakcji dla klasy UserControl.xaml
    /// </summary>
    public partial class UserControl_1 : UserControl
    {
        public event EventHandler<Register_eventargs> RegisterAttempt;
        public UserControl_model control_m { get; set; }
        public UserControl_1()
        {
            control_m = new UserControl_model();
            DataContext = control_m;
            InitializeComponent();
         
        }
        private void RegisterAction(object sender, RoutedEventArgs e)
        {
            RegisterAttempt?.Invoke(this, new Register_eventargs(control_m.model.login, control_m.model.password, control_m.model.r_password, control_m.model.accept, control_m.model.oi_info, control_m.model.oi_info1, control_m.model.oi_info2));
            us1_Name.Clear();
            us1_Passw.Clear();
            us1_RPassw.Clear();
            oi_info1.Clear();
            oi_info2.Clear();
        }


        private void other_info_Click(object sender, RoutedEventArgs e)
        {
            if (other_info.IsChecked == true)
            {
                oi_info1.IsEnabled = true;
                oi_info2.IsEnabled = true;
            }
            else
            {
                oi_info1.IsEnabled = false;
                oi_info2.IsEnabled = false;
            }

        }
    }
}
