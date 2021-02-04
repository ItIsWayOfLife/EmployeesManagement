
namespace EmployeesManagement.Core.Interfaces.IRepositories.Common
{
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
