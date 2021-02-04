using EmployeesManagement.Core.Exceptions;
using EmployeesManagement.Core.Interfaces.IServices;
using EmployeesManagement.Web.Interfaces.IViewConverters;
using EmployeesManagement.Web.Models.Employee;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeesManagement.Web.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IEmployeeService _empoyeeService;
        private readonly IPositionService _positionService;
        private readonly ICompanyService _companyService;
        private readonly IEmployeeViewConverter _employeeViewConverter;

        public EmployeeController(IEmployeeService empoyeeService,
            IPositionService positionService,
            ICompanyService companyService,
            IEmployeeViewConverter employeeViewConverter)
        {
            _empoyeeService = empoyeeService;
            _positionService = positionService;
            _companyService = companyService;
            _employeeViewConverter = employeeViewConverter;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var employeeDTOs = _empoyeeService.GetAll();

            var emoloyeeViews = _employeeViewConverter.ConvertModelsToViewModels(employeeDTOs);

            return View(emoloyeeViews);
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View(new AddEmployeeSelectListViewModel()
            {
                AddEmployeeViewModel = new AddEmployeeViewModel() { DateEmployment = DateTime.Now },
                Positions = null,
                Companies = null
            });
        }

       
    }
}
