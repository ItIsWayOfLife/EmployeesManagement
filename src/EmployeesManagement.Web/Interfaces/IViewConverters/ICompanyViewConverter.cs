using EmployeesManagement.Core.DTOs;
using EmployeesManagement.Web.Interfaces.IViewConverters.Common;
using EmployeesManagement.Web.Models.Company;

namespace EmployeesManagement.Web.Interfaces.IViewConverters
{
    public interface ICompanyViewConverter : IViewConverter<CompanyDTO, CompanyViewModel>,
         IAddViewConverter<AddCompanyViewModel, CompanyDTO>,
         IEditViewConverter<EditCompanyViewModel, CompanyDTO>
    {

    }
}
