using EmployeesManagement.Core.Entities;
using EmployeesManagement.Web.Interfaces.IViewConverters.Common;
using EmployeesManagement.Web.Models.Position;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeesManagement.Web.Interfaces.IViewConverters
{
    public interface IPositionViewConverter : IViewConverter<Position, PositionViewModel>
    {

    }
}
