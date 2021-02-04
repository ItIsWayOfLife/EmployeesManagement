using EmployeesManagement.Core.DTOs;
using EmployeesManagement.Core.Entities;
using EmployeesManagement.Core.Interfaces;

namespace EmployeesManagement.Core.Converters
{
    public class EmployeeConverter : IConverter<Employee, EmployeeDTO>
    {
        public Employee ConvertDTOToModel(EmployeeDTO modelDTO)
        {
            return new Employee()
            {
                Id = modelDTO.Id,
                Firstname = modelDTO.Firstname,
                Secondname = modelDTO.Secondname,
                Middlename = modelDTO.Middlename,
                DateEmployment = modelDTO.DateEmployment
            };
        }

        public EmployeeDTO ConvertModelToDTO(Employee model)
        {
            return new EmployeeDTO()
            {
                Id = model.Id,
                Firstname = model.Firstname,
                Secondname = model.Secondname,
                Middlename = model.Middlename,
                DateEmployment = model.DateEmployment,
                CompanyName = model.Company.Name,
                PositionName = model.Position.Name
            };
        }
    }
}
