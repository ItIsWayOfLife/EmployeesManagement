using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeesManagement.Web.Models.Company
{
    public class AddCompanySelectListViewModel
    {
        public AddCompanyViewModel AddCompanyViewModel { get; set; }
        public SelectList LegalForms { get; set; }
        public SelectList Activities { get; set; }
    }
}
