using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeesManagement.Web.Models.Company
{
    public class EditCompanyViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LegalFormName { get; set; }
        public string ActivityName { get; set; }
    }
}
