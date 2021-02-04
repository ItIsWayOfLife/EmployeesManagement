using EmployeesManagement.Core.DTOs;
using EmployeesManagement.Core.Interfaces.IServices.Common;
using System;

namespace EmployeesManagement.Core.Interfaces.IServices
{
    public interface IEmployeeService : ICrudableService<EmployeeDTO>, IDisposable
    {

    }
}
