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
        public Main_view_model MW_model { get; set; }
        private FakeDB database { get; set; }
        public MainWindow()
        {
            InitializeComponent();
#pragma warning disable CS0612 // Typ lub składowa jest przestarzała
            MW_model = new Main_view_model();
#pragma warning restore CS0612 // Typ lub składowa jest przestarzała
            database = new FakeDB();
        }
        private void UserControl_1_RegisterAttempt(object sender, Register_eventargs e)
        {
            MW_model.mod.login = e.login;
            MW_model.mod.password = e.password;
            MW_model.mod.r_password = e.password;
            MW_model.mod.accept = e.accept;

            var result = MW_model.mod_va.Validate(MW_model.mod);
            Errors.Text = string.Join("|", result.Errors);

            if (result.IsValid)
                database.RegisterUser(MW_model.mod);
        }
    }
}
