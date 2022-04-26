using Cursach3.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Cursach3.Commands
{
    public class DeleteProductCommand : Command
    {
        private readonly AdminWindowViewModel _viewModel;

        public DeleteProductCommand(AdminWindowViewModel viewModel)
        {
            _viewModel = viewModel;
        }

        public override void Execute(object parameter)
        {
            if (_viewModel.SelectedProduct == null)
                return;
            
            var productId = _viewModel.SelectedProduct.IdProduct;
        }
    }
}
