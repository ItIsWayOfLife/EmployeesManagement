using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeesManagement.Core.Interfaces.IRepositories.Common
{
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
