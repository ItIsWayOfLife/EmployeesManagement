using EmployeesManagement.Core.DTOs;
using EmployeesManagement.Core.Interfaces.IServices.Common;
using System;

namespace EmployeesManagement.Core.Interfaces.IServices
{
    /// <summary>
    /// Service for working with model CompanyDTO.
    /// </summary>
    public interface ICompanyService : ICrudableService<CompanyDTO>, IGetAllName, IDisposable
    {

    }
}
