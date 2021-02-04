using System.Collections.Generic;

namespace EmployeesManagement.Core.Interfaces.IRepositories.Common
{
    /// <summary>
    /// Read operations with entity model.
    /// </summary>
    /// <typeparam name="T">Entity model.</typeparam>
    public interface IGetableRepository<T> where T : class
    {
        /// <summary>
        /// Get all models.
        /// </summary>
        /// <returns>IEnumerable models.</returns>
        IEnumerable<T> GetAll();

        /// <summary>
        /// Get one model.
        /// </summary>
        /// <param name="id">Id getable model.</param>
        /// <returns>One model.</returns>
        T Get(int id);
    }
}
