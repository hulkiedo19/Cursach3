using Cursach3.Commands;
using Cursach3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Cursach3.ViewModels
{
    public class AdminWindowViewModel : ViewModel
    {
        private List<Models.Material> _materials;
        private List<Models.Process> _processes;
        private List<Models.Product> _products;

        private Material _selectedMaterial;
        private Process _selectedProcess;
        private Product _selectedProduct;

        public ICommand DeleteMaterial => new DeleteMaterialCommand(this);
        public ICommand DeleteProcess => new DeleteProcessCommand(this);
        public ICommand DeleteProduct => new DeleteProductCommand(this);

        public AdminWindowViewModel()
        {
            using(var databaseEntities = new DatabaseEntities())
            {
                _materials = databaseEntities.Materials
                    .Include(nameof(Material.MaterialType1))
                    .ToList();

                _processes = databaseEntities.Processes
                    .Include(nameof(Process.Material))
                    .Include(nameof(Process.ProductType1))
                    .Include(nameof(Process.Department))
                    .ToList();

                _products = databaseEntities.Products
                    .Include(nameof(Process.ProductType1))
                    .ToList();
            }
        }

        public List<Models.Material> Materials
        {
            get => _materials;
            set => Set(ref _materials, value, nameof(Material));
        }

        public List<Models.Process> Processes
        {
            get => _processes;
            set => Set(ref _processes, value, nameof(Process));
        }

        public List<Models.Product> Products
        {
            get => _products;
            set => Set(ref _products, value, nameof(Product));
        }

        public Material SelectedMaterial
        {
            get => _selectedMaterial;
            set => Set(ref _selectedMaterial, value, nameof(Material));
        }

        public Process SelectedProcess
        {
            get => _selectedProcess;
            set => Set(ref _selectedProcess, value, nameof(Process));
        }

        public Product SelectedProduct
        {
            get => _selectedProduct;
            set => Set(ref _selectedProduct, value, nameof(Product));
        }
    }
}
