using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Cursach3.Commands
{
    public class OpenCloseWindowCommand : Command
    {
        private Window _newWindow;
        private Window _oldWindow;

        public OpenCloseWindowCommand(Window newWindow, Window oldWindow)
        {
            _newWindow = newWindow;
            _oldWindow = oldWindow;
        }

        public override void Execute(object parameter)
        {
            _newWindow.Show();
            _oldWindow.Close();
        }
    }
}
