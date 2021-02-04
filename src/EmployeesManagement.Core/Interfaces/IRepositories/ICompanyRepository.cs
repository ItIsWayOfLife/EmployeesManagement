using EmployeesManagement.Core.Entities;
using EmployeesManagement.Core.Interfaces.IRepositories.Common;

namespace EmployeesManagement.Core.Interfaces.IRepositories
{
    public interface ICompanyRepository : ICrudableRepository<Company>
    {
        /// <summary>
        /// Get current size company by company id.
        /// </summary>
        /// <param name="companyId">Company id.</param>
        /// <returns>Size company.</returns>
        int GetCurrentSizeByCompanyId(int companyId);
    }
}
