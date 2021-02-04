
using Microsoft.AspNetCore.Mvc.Rendering;

namespace EmployeesManagement.Web.Models.Employee
{
    public class AddEmployeeSelectListViewModel
    {
        public AddEmployeeViewModel AddEmployeeViewModel { get; set; }
        public SelectList Positions { get; set; }
        public SelectList Companies { get; set; }
    }
}
