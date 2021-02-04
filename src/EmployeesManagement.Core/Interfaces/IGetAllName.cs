using System.Collections.Generic;

namespace EmployeesManagement.Core.Interfaces
{
    public interface IGetAllName
    {
        /// <summary>
        /// Get all names.
        /// </summary>
        /// <returns>All names.</returns>
        public IEnumerable<string> GetAllName();
    }
}
