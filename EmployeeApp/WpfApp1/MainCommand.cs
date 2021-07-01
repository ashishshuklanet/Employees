using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Employees
{
    /// <summary>
    /// Main command class
    /// </summary>
    public class MainCommand : ICommand
    {
        #region Constructors

        public MainCommand(Action<object> execute, Predicate<object> canExecute)
        {
            _execute = execute;
            _canExecute = canExecute;
            CanExecuteChanged += MainCommand_CanExecuteChanged;
        }

        #endregion

        #region ICommand Members

        public event EventHandler CanExecuteChanged;
        

        public bool CanExecute(object parameter)
        {
            return _canExecute(parameter);
        }

        public void Execute(object parameter)
        {
            if (_execute != null)
                _execute(parameter);

           
        }

        private void MainCommand_CanExecuteChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private readonly Action<object> _execute = null;
        private readonly Predicate<object> _canExecute = null;
    }
}
