using EmployeesManagement.Core.DTOs;
using EmployeesManagement.Core.Entities;
using EmployeesManagement.Core.Interfaces;
using EmployeesManagement.Core.Interfaces.IServices;
using EmployeesManagement.Core.Services.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeesManagement.Core.Services
{
    public class EmployeeService : Service, IEmployeeService
    {
        private readonly IConverter<Employee, EmployeeDTO> _employeeConverter;

        public EmployeeService(IUnitOfWork uow,
            IConverter<Employee, EmployeeDTO> employeeConverter) : base(uow)
        {
            _employeeConverter = employeeConverter;
        }

        public void Add(EmployeeDTO model)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void Edit(EmployeeDTO model)
        {
            throw new NotImplementedException();
        }

        public EmployeeDTO Get(int id)
        {
            var employee = Database.Employee.Get(id);

            var employeeDTO = ConvertEmployeeToEmployeeDTO(employee);

            return employeeDTO;
        }

        public IEnumerable<EmployeeDTO> GetAll()
        {
            var employees = Database.Employee.GetAll();

            var employeeDTOs = new List<EmployeeDTO>();

            foreach (var employee in employees)
            {
                employeeDTOs.Add(ConvertEmployeeToEmployeeDTO(employee));
            }

            return employeeDTOs;
        }

        private EmployeeDTO ConvertEmployeeToEmployeeDTO(Employee employee)
        {
            employee.Position = Database.Position.Get(employee.PositionId);
            employee.Company = Database.Company.Get(employee.CompanyId);

            var employeeDTO =  _employeeConverter.ConvertModelByDTO(employee);

            return employeeDTO;
        }
    }
}
