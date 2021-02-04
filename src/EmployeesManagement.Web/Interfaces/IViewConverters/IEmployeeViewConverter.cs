using EmployeesManagement.Core.DTOs;
using EmployeesManagement.Web.Interfaces.IViewConverters.Common;
using EmployeesManagement.Web.Models.Employee;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeesManagement.Web.Interfaces.IViewConverters
{
    public interface IEmployeeViewConverter : IViewConverter<EmployeeDTO, EmployeeViewModel>,
       IAddViewConverter<AddEmployeeViewModel, EmployeeDTO>,
       IEditViewConverter<EditEmployeeViewModel, EmployeeDTO>
    {
    }
}
