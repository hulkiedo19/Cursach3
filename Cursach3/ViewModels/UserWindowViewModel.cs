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
    public class UserWindowViewModel : ViewModel
    {
        private List<Models.Department> _departments;
        private List<Models.ProductType> _productTypes;
        private List<Models.MaterialType> _materialTypes;
        private List<Models.WorkType> _workTypes;

        public UserWindowViewModel()
        {
            using(var databaseContext = new DatabaseEntities())
            {
                _departments = databaseContext.Departments
                    .ToList();

                _productTypes = databaseContext.ProductTypes
                    .ToList();

                _materialTypes = databaseContext.MaterialTypes
                    .ToList();

                _workTypes = databaseContext.WorkTypes
                    .ToList();
            }
        }

        public List<Department> Departments
        {
            get => _departments;
            set => Set(ref _departments, value, nameof(Departments));
        }

        public List<ProductType> ProductTypes
        {
            get => _productTypes;
            set => Set(ref _productTypes, value, nameof(ProductTypes));
        }

        public List<MaterialType> MaterialTypes
        {
            get => _materialTypes;
            set => Set(ref _materialTypes, value, nameof(MaterialTypes));
        }

        public List<WorkType> WorkTypes
        {
            get => _workTypes;
            set => Set(ref _workTypes, value, nameof(WorkTypes));
        }
    }
}
