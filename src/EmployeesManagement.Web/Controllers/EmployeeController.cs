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
                Positions = new SelectList(_positionService.GetAllName()),
                Companies = new SelectList(_companyService.GetAllName())
            });
        }

        [HttpPost]
        public IActionResult Add(AddEmployeeSelectListViewModel model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var employeeDTO = _employeeViewConverter.ConvertAddViewModelToModel(model.AddEmployeeViewModel);

                    _empoyeeService.Add(employeeDTO);

                    return RedirectToAction(nameof(Index));
                }
                catch (ValidationException ex)
                {
                    ModelState.AddModelError(ex.Property, ex.Message);
                }
            }

            model.Positions = new SelectList(_positionService.GetAllName());
            model.Companies = new SelectList(_companyService.GetAllName());

            return View(model);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var employeeDTO = _empoyeeService.Get(id);

            if (employeeDTO == null)
            {
                return RedirectToAction("Error", "Home", new { requestId = "400", errorInfo = "Сотрудник не найден" });
            }

            return View(new EditEmployeeSelectListViewModel()
            {
                EditEmployeeViewModel = _employeeViewConverter.ConvertModelToEditViewModel(employeeDTO),
                Companies = new SelectList(_companyService.GetAllName()),
                Positions = new SelectList(_positionService.GetAllName())
            });
        }

        [HttpPost]
        public IActionResult Edit(EditEmployeeSelectListViewModel model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var employeeDTO = _employeeViewConverter.ConvertEditViewModelToModel(model.EditEmployeeViewModel);

                    _empoyeeService.Edit(employeeDTO);

                    return RedirectToAction(nameof(Index));
                }
                catch (ValidationException ex)
                {
                    ModelState.AddModelError(ex.Property, ex.Message);
                }
            }

            model.Positions = new SelectList(_positionService.GetAllName());
            model.Companies = new SelectList(_companyService.GetAllName());

            return View(model);
        }
    }
}
