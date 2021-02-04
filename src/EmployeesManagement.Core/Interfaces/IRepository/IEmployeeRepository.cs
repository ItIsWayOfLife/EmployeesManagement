﻿using EmployeesManagement.Core.Entities;
using EmployeesManagement.Core.Interfaces.IRepository.Common;

namespace EmployeesManagement.Core.Interfaces.IRepository
{
    public interface IEmployeeRepository : ICrudableRepository<Employee>
    {

    }
}