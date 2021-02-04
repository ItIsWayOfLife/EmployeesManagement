using EmployeesManagement.Core.DTOs;
using EmployeesManagement.Core.Interfaces.IServices.Common;
using System;

namespace EmployeesManagement.Core.Interfaces.IServices
{
    /// <summary>
    /// Service for working with model EmployeeDTO.
    /// </summary>
    public interface IEmployeeService : ICrudableService<EmployeeDTO>, IDisposable
    {

    }
}
