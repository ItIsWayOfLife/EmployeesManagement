
namespace EmployeesManagement.Core.Interfaces.IServices.Common
{
    /// <summary>
    /// CRUD (Create, read, update and delete) operations with model.
    /// </summary>
    /// <typeparam name="T">Model.</typeparam>
    public interface ICrudableService<T> : IGetAllService<T> where T : class
    {
        /// <summary>
        /// Get one model.
        /// </summary>
        /// <param name="id">Id getable model.</param>
        /// <returns>One model.</returns>
        T Get(int id);

        /// <summary>
        /// Add new model.
        /// </summary>
        /// <param name="model">Addable model.</param>
        void Add(T model);

        /// <summary>
        /// Edit model.
        /// </summary>
        /// <param name="model">Editable model.</param>
        void Edit(T model);

        /// <summary>
        /// Delete model.
        /// </summary>
        /// <param name="id">Id deletable model.</param>
        void Delete(int id);
    }
}
