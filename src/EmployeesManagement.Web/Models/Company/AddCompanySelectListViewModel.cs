using Microsoft.AspNetCore.Mvc.Rendering;

namespace EmployeesManagement.Web.Models.Company
{
    public class AddCompanySelectListViewModel
    {
        public AddCompanyViewModel AddCompanyViewModel { get; set; }
        public SelectList LegalForms { get; set; }
        public SelectList Activities { get; set; }
    }
}
