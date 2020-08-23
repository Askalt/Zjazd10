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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public Main_view_model model { get; set; }
        private FakeDB database { get; set; }

        [Obsolete]
        public MainWindow()
        {
            InitializeComponent();
            model = new Main_view_model();
            database = new FakeDB();
        }
        private void UserControl_1_RegisterAttempt(object sender, Register_eventargs e)
        {
            model.mod.login = e.login;
            model.mod.password = e.password;
            model.mod.r_password = e.password;
            model.mod.accept = e.accept;

            var result = model.mod_va.Validate(model.mod);
            Errors.Text = string.Join("|", result.Errors);

            if (result.IsValid)
                database.RegisterUser(model.mod);

        }
    }
}
