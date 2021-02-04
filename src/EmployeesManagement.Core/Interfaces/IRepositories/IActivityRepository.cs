using EmployeesManagement.Core.Entities;
using EmployeesManagement.Core.Interfaces.IRepositories.Common;

namespace EmployeesManagement.Core.Interfaces.IRepositories
{
    public interface IActivityRepository : IGetableRepository<Activity>
    {
        /// <summary>
        /// Get activity id by activity name.
        /// </summary>
        /// <param name="activityName">Activity name.</param>
        /// <returns>Id activity.</returns>
        int? GetActivityIdByActivityName(string activityName);
    }
}
