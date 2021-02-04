using EmployeesManagement.Core.Entities;
using EmployeesManagement.Core.Interfaces.IRepositories.Common;

namespace EmployeesManagement.Core.Interfaces.IRepositories
{
    /// <summary>
    /// Repository for working DB with entity Position.
    /// </summary>
    public interface IPositionRepository : IGetableRepository<Position>, IGetIdByName, IGetAllName
    {

    }
}
