using EmployeesManagement.Core.DTOs;
using EmployeesManagement.Core.Entities;
using EmployeesManagement.Core.Exceptions;
using EmployeesManagement.Core.Interfaces;
using EmployeesManagement.Core.Interfaces.IServices;
using EmployeesManagement.Core.Services.Common;
using System.Collections.Generic;

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

        public void Add(EmployeeDTO model)
        {
            int positionId = GetPositionIdByPositionName(model.PositionName);
            int companyId = GetCompanyIdByCompanyName(model.CompanyName);

            var employee = _employeeConverter.ConvertDTOToModel(model);

            employee.PositionId = positionId;
            employee.CompanyId = companyId;

            Database.Employee.Create(employee);
            Database.Save();
        }

        public void Edit(EmployeeDTO model)
        {
            var employee = Database.Employee.Get(model.Id);

            if (employee == null)
                throw new ValidationException("Работник не найден", string.Empty);

            int positionId = GetPositionIdByPositionName(model.PositionName);
            int companyId = GetCompanyIdByCompanyName(model.CompanyName);

            employee = _employeeConverter.ConvertDTOToModel(model);

            employee.CompanyId = companyId;
            employee.PositionId = positionId;

            Database.Employee.Update(employee);
            Database.Save();
        }

        public void Delete(int id)
        {
            Database.Employee.Delete(id);
            Database.Save();
        }

        /// <summary>
        /// Get position id by position name.
        /// </summary>
        /// <param name="positionName">Position name.</param>
        /// <returns>Id position.</returns>
        private int GetPositionIdByPositionName(string positionName)
        {
            int? positionId = Database.Position.GetIdByName(positionName);

            if (positionId == null)
            {
                throw new ValidationException($"Не установлена должность", string.Empty);
            }

            return positionId.Value;
        }

        /// <summary>
        /// Get company id by company name.
        /// </summary>
        /// <param name="companyName">Company name.</param>
        /// <returns>Id company.</returns>
        private int GetCompanyIdByCompanyName(string companyName)
        {
            int? companyId = Database.Company.GetIdByName(companyName);

            if (companyId == null)
            {
                throw new ValidationException($"Не установлена компания", string.Empty);
            }

            return companyId.Value;
        }

        /// <summary>
        /// Convert employee to employeeDTO.
        /// </summary>
        /// <param name="employee">Model employee.</param>
        /// <returns>Model employeeDTO.</returns>
        private EmployeeDTO ConvertEmployeeToEmployeeDTO(Employee employee)
        {
            employee.Position = Database.Position.Get(employee.PositionId);
            employee.Company = Database.Company.Get(employee.CompanyId);

            var employeeDTO =  _employeeConverter.ConvertModelToDTO(employee);

            return employeeDTO;
        }
    }
}
