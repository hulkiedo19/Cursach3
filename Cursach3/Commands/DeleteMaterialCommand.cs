using Cursach3.Models;
using Cursach3.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Cursach3.Commands
{
    public class DeleteMaterialCommand : Command
    {
        private readonly AdminWindowViewModel _viewModel;

        public DeleteMaterialCommand(AdminWindowViewModel viewModel)
        {
            _viewModel = viewModel;
        }

        public override void Execute(object parameter)
        {
            if (_viewModel.SelectedMaterial == null)
                return;

            int MaterialId = _viewModel.SelectedMaterial.IdMaterial;

            using(var DatabaseContext = new DatabaseEntities())
            {
                var material = DatabaseContext.Materials
                    .Where(t => t.IdMaterial == MaterialId)
                    .Single();

                DatabaseContext.Materials.Remove(material);
                DatabaseContext.SaveChanges();
            }

            UpdateMaterials();
        }

        private void UpdateMaterials()
        {
            using (var DatabaseContext = new DatabaseEntities())
            {
                _viewModel.Materials = DatabaseContext.Materials
                    .Include(nameof(Material.MaterialType1))
                    .ToList();
            }
        }
    }
}
