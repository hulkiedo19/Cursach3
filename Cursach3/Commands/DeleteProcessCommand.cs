using Cursach3.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Cursach3.Commands
{
    public class DeleteProcessCommand : Command
    {
        private readonly AdminWindowViewModel _viewModel;

        public DeleteProcessCommand(AdminWindowViewModel viewModel)
        {
            _viewModel = viewModel;
        }

        public override void Execute(object parameter)
        {
            if(_viewModel.SelectedProcess == null)
            {
                MessageBox.Show("null");
            } else
            {
                MessageBox.Show("not null");
            }
        }
    }
}
