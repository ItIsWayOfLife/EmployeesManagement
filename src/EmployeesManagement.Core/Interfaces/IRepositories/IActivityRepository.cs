﻿using EmployeesManagement.Core.Entities;
using EmployeesManagement.Core.Interfaces.IRepositories.Common;

namespace EmployeesManagement.Core.Interfaces.IRepositories
{
    public interface IActivityRepository : IGetableRepository<Activity>, IGetIdByName
    {

    }
}
