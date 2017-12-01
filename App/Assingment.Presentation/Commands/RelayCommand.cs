using System;
using System.Windows.Input;

namespace Assingment.Presentation.Commands
{
    public delegate void ExecuteDelegate(object obj);
    public delegate bool CanExecuteDelegate(object obj);

    class RelayCommand : ICommand
    {
        ExecuteDelegate execute;
        CanExecuteDelegate canExecute;

        public RelayCommand(ExecuteDelegate execute, CanExecuteDelegate canExecute = null)
        {
            this.execute = execute;
            this.canExecute = canExecute;
        }

        public bool CanExecute(object parameter)
        {
            if (canExecute == null)
            {
                return true;
            }
            return canExecute(parameter);
        }

        public event EventHandler CanExecuteChanged;

        public void Execute(object parameter)
        {
            execute(parameter);
        }
    }
}