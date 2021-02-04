using Microsoft.AspNetCore.Mvc.Rendering;

namespace EmployeesManagement.Web.Models.Company
{
    public class EditCompanySelectListViewModel
    {
        public EditCompanyViewModel EditCompanyViewModel { get; set; }
        public SelectList LegalForms { get; set; }
        public SelectList Activities { get; set; }
    }
}
