using EmployeesManagement.Core.DTOs;
using EmployeesManagement.Web.Interfaces.IViewConverters.Common;
using EmployeesManagement.Web.Models.Employee;

namespace EmployeesManagement.Web.Interfaces.IViewConverters
{
    public interface IEmployeeViewConverter : IViewConverter<EmployeeDTO, EmployeeViewModel>,
       IAddViewConverter<AddEmployeeViewModel, EmployeeDTO>,
       IEditViewConverter<EditEmployeeViewModel, EmployeeDTO>
    {

    }
}
