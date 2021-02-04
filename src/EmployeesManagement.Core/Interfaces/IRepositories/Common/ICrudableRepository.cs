
namespace EmployeesManagement.Core.Interfaces.IRepositories.Common
{
    /// <summary>
    /// CRUD (Create, read, update and delete) operations with entity model.
    /// </summary>
    /// <typeparam name="T">Entity model.</typeparam>
    public interface ICrudableRepository<T> : IGetableRepository<T> where T : class
    {
        /// <summary>
        /// Create new model.
        /// </summary>
        /// <param name="item">Creatable model.</param>
        void Create(T item);

        /// <summary>
        /// Update model.
        /// </summary>
        /// <param name="item">Updatable model.</param>
        void Update(T item);

        /// <summary>
        /// Delete model.
        /// </summary>
        /// <param name="id">Id deletable model.</param>
        void Delete(int id);
    }
}
