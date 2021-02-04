
namespace EmployeesManagement.Core.Interfaces.IRepositories.Common
{
    /// <summary>
    /// Read operation id by name.
    /// </summary>
    public interface IGetIdByName
    {
        /// <summary>
        /// Get model id by model name.
        /// </summary>
        /// <param name="activityName">Model name.</param>
        /// <returns>Id model.</returns>
       public int? GetIdByName(string name);
    }
}
