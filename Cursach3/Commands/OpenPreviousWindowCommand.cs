using Cursach3.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Cursach3.Commands
{
    public class OpenPreviousWindowCommand : Command
    {
        private string _oldWindow;
        private int _newWindow;

        public OpenPreviousWindowCommand(string oldWindow, int newWindow)
        {
            _oldWindow = oldWindow;
            _newWindow = newWindow;
        }

        public override void Execute(object parameter)
        {
            int curWindowIndex = 0;
            foreach (Window item in Application.Current.Windows)
            {
                if (item.Title == _oldWindow) { break; }
                curWindowIndex++;
            }

            OpenCloseWindowCommand command = null;

            switch(_newWindow)
            {
                case 0:
                    command = new OpenCloseWindowCommand(new MainWindow(), Application.Current.Windows[curWindowIndex]);
                    break;
                case 1:
                    command = new OpenCloseWindowCommand(new AdminWindow(), Application.Current.Windows[curWindowIndex]);
                    break;
                case 2:
                    command = new OpenCloseWindowCommand(new UserWindow(), Application.Current.Windows[curWindowIndex]);
                    break;
            }

            command.Execute(parameter);
        }
    }
}
