using EmployeesManagement.Core.Entities;
using EmployeesManagement.Core.Interfaces.IRepositories.Common;

namespace EmployeesManagement.Core.Interfaces.IRepositories
{
    /// <summary>
    /// Repository for working DB with entity LegalForm.
    /// </summary>
    public interface ILegalFormRepository : IGetableRepository<LegalForm>, IGetIdByName, IGetAllName
    {

    }
}
