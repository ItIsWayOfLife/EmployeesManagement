using Microsoft.AspNetCore.Mvc.Rendering;

namespace EmployeesManagement.Web.Models.Employee
{
    public class EditEmployeeSelectListViewModel
    {
        public EditEmployeeViewModel EditEmployeeViewModel { get; set; }
        public SelectList Positions { get; set; }
        public SelectList Companies { get; set; }
    }
}
