using System.Collections.Generic;

namespace EmployeesManagement.Core.Interfaces.IRepository.Common
{
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
        /// <param name="id">Id model.</param>
        /// <returns>One model.</returns>
        T Get(int id);
    }
}
