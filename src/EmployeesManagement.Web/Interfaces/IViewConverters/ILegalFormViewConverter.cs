using EmployeesManagement.Core.Entities;
using EmployeesManagement.Web.Interfaces.IViewConverters.Common;
using EmployeesManagement.Web.Models.LegalForm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeesManagement.Web.Interfaces.IViewConverters
{
    public interface ILegalFormViewConverter : IViewConverter<LegalForm, LegalFormViewModel>
    {

    }
}
