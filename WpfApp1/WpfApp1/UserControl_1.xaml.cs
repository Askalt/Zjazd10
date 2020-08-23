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
        public UserControl_model control_model { get; set; }
        public UserControl_1()
        {
            control_model = new UserControl_model();
            DataContext = control_model;
            InitializeComponent();

        }
        private void RegisterAction(object sender, RoutedEventArgs e)
        {
            RegisterAttempt?.Invoke(this, new Register_eventargs(control_model.model.login, control_model.model.password, control_model.model.r_password, control_model.model.accept));
            tb_Name.Clear();
            tb_Passw.Clear();
            tb_RPassw.Clear();
        }
    }
}
