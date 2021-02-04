using EmployeesManagement.Core.Entities;
using EmployeesManagement.Web.Interfaces.IConverters.Common;
using EmployeesManagement.Web.Models.Position;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeesManagement.Web.Interfaces.IConverters
{
    public interface IPositionConverter : IViewConverter<Position, PositionViewModel>
    {

    }
}
