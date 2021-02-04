using EmployeesManagement.Core.Entities;
using EmployeesManagement.Core.Interfaces.IServices.Common;
using System;

namespace EmployeesManagement.Core.Interfaces.IServices
{
    /// <summary>
    /// Service for working with model LegalForm.
    /// </summary>
    public interface ILegalFormService : IGetAllService<LegalForm>, IGetAllName, IDisposable
    {

    }
}
