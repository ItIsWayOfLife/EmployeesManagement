﻿using EmployeesManagement.Core.Entities;
using EmployeesManagement.Core.Interfaces.IRepositories.Common;

namespace EmployeesManagement.Core.Interfaces.IRepositories
{
    /// <summary>
    /// Repository for working DB with entity Activity.
    /// </summary>
    public interface IActivityRepository : IGetableRepository<Activity>, IGetIdByName, IGetAllName
    {

    }
}
