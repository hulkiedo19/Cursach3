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

        public OpenPreviousWindowCommand(string oldWindow)
        {
            _oldWindow = oldWindow;
        }

        public override void Execute(object parameter)
        {
            int curWindowIndex = 0;
            foreach (Window item in Application.Current.Windows)
            {
                if (item.Title == _oldWindow) { break; }
                curWindowIndex++;
            }

            var command = new OpenCloseWindowCommand(new MainWindow(), Application.Current.Windows[curWindowIndex]);
            command.Execute(parameter);
        }
    }
}
