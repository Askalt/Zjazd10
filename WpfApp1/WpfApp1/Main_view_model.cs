using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
        public class Main_view_model
        {
            public FakeDB database { get; set; }

     
        public Main_view_model()
            {
                mod = new Registration_model();
                mod_va = new Registration_model_validation();
            }
            public Registration_model mod { get; set; }
            public Registration_model_validation mod_va;
        }
  
}
