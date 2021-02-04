﻿using EmployeesManagement.Core.Entities;
using EmployeesManagement.Core.Interfaces.IServices.Common;
using System;

namespace EmployeesManagement.Core.Interfaces.IServices
{
    public interface IActivityService : IGetAllService<Activity>, IGetAllName, IDisposable
    {

    }
}