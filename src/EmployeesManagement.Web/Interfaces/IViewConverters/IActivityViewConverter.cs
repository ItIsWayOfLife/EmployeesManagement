using EmployeesManagement.Core.Entities;
using EmployeesManagement.Web.Interfaces.IViewConverters.Common;
using EmployeesManagement.Web.Models.Activity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeesManagement.Web.Interfaces.IViewConverters
{
    public interface IActivityViewConverter : IViewConverter<Activity, ActivityViewModel>
    {

    }
}
