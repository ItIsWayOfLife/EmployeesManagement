using EmployeesManagement.Core.Interfaces.IServices;
using EmployeesManagement.Web.Models.Company;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeesManagement.Web.Controllers
{
    public class CompanyController : Controller
    {
        private readonly ICompanyService _companyService;

        public CompanyController(ICompanyService companyService)
        {
            _companyService = companyService;
        }

        public IActionResult Index()
        {
            var models = _companyService.GetAll();

            var companyViewModels = new List<CompanyViewModel>();

            foreach (var model in models)
            {
                companyViewModels.Add(new CompanyViewModel()
                {
                    Id = model.Id,
                    Name = model.Name,
                    ActivityName = model.ActivityName,
                    LegalFormName = model.LegalFormName,
                    Size = model.Size
                });
            }

            return View(companyViewModels);
        }
    }
}
