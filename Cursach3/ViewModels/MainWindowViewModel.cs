﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using Cursach3.Commands;
using Cursach3.Views;

namespace Cursach3.ViewModels
{
    public class MainWindowViewModel
    {
        public ICommand GoToAdmin => new OpenCloseWindowCommand(new AdminWindow(), Application.Current.MainWindow);
    }
}