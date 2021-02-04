using EmployeesManagement.Core.DTOs;
using EmployeesManagement.Web.Interfaces.IViewConverters;
using EmployeesManagement.Web.Models.Employee;
using System.Collections.Generic;

namespace EmployeesManagement.Web.Converters
{
    public class EmployeeViewConverter : IEmployeeViewConverter
    {
        public IEnumerable<EmployeeViewModel> ConvertModelsToViewModels(IEnumerable<EmployeeDTO> models)
        {
            var employeeViewModels = new List<EmployeeViewModel>();

            foreach (var employeeDTO in models)
            {
                employeeViewModels.Add(new EmployeeViewModel()
                {
                    Id = employeeDTO.Id,
                    Firstname = employeeDTO.Firstname,
                    Secondname = employeeDTO.Secondname,
                    Middlename = employeeDTO.Middlename,
                    PositionName = employeeDTO.PositionName,
                    CompanyName = employeeDTO.CompanyName,
                    DateEmployment = employeeDTO.DateEmployment
                });
            }

            return employeeViewModels;
        }

        public EmployeeDTO ConvertAddViewModelToModel(AddEmployeeViewModel model)
        {
            return new EmployeeDTO()
            {
                Firstname = model.Firstname,
                Secondname = model.Secondname,
                Middlename = model.Middlename,
                DateEmployment = model.DateEmployment,
                PositionName = model.PositionName,
                CompanyName = model.CompanyName
            };
        }

        public EditEmployeeViewModel ConvertModelToEditViewModel(EmployeeDTO model)
        {
            return new EditEmployeeViewModel()
            {
                Id = model.Id,
                Firstname = model.Firstname,
                Secondname = model.Secondname,
                Middlename = model.Middlename,
                DateEmployment = model.DateEmployment,
                PositionName = model.PositionName,
                CompanyName = model.CompanyName
            };
        }

        public EmployeeDTO ConvertEditViewModelToModel(EditEmployeeViewModel editEmployeeViewModel)
        {
            return new EmployeeDTO()
            {
                Id = editEmployeeViewModel.Id,
                Firstname = editEmployeeViewModel.Firstname,
                Secondname = editEmployeeViewModel.Secondname,
                Middlename = editEmployeeViewModel.Middlename,
                DateEmployment = editEmployeeViewModel.DateEmployment,
                PositionName = editEmployeeViewModel.PositionName,
                CompanyName = editEmployeeViewModel.CompanyName
            };
        }
    }
}
