using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WinWlan.Commands
{
    class ScanCommand: ICommand
    {
        private Action _excute;
        private Func<bool> _canExcute;

        public ScanCommand(Action excute) : this(excute, null)
        {
        }

        public ScanCommand(Action excute, Func<bool> canExcute)
        {
            if (excute == null)
                throw new ArgumentException("No excute");
            _excute = excute;
            _canExcute = canExcute;
        }

        public event EventHandler CanExecuteChanged
        {
            add
            {
                if (_canExcute != null)
                {
                    CommandManager.RequerySuggested += value;
                }
            }
            remove
            {
                if (_canExcute != null)
                {
                    CommandManager.RequerySuggested -= value;
                }
            }
        }
        
        public bool CanExecute(object parameter)
        {
            return _canExcute == null ? true : _canExcute();
        }

        public void Execute(object parameter)
        {
            _excute();
        }
    }
}
