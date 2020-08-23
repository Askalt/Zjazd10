using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using FluentValidation;

namespace WpfApp1
{
    public class Register_command : ICommand
    {
        public Registration_model_validation valid;

        [Obsolete]
        public bool CanExecute(object parameter)
        {
            if (parameter != null)
            {
                if (parameter is object && parameter is Registration_model)
                {
                    var model = parameter as Registration_model;
                    valid = new Registration_model_validation();
                    if (valid.Validate(model).IsValid && model.password == model.r_password)
                        return true;
                    else
                        return false;
                }
                else
                {
                    return false;
                }
            }
            else
                return false;
        }
        public void Execute(object parameter)
        {

        }
        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }
    }
}
