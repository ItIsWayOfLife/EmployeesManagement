using EmployeesManagement.Core.Entities;
using EmployeesManagement.Core.Interfaces.IServices.Common;
using System;

namespace EmployeesManagement.Core.Interfaces.IServices
{
    /// <summary>
    /// Service for working with model Activity.
    /// </summary>
    public interface IActivityService : IGetAllService<Activity>, IGetAllName, IDisposable
    {

    }
}
