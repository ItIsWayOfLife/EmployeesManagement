using EmployeesManagement.Core.Interfaces.IServices;
using EmployeesManagement.Web.Interfaces.IConverters;
using EmployeesManagement.Web.Models.LegalForm;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace EmployeesManagement.Web.Controllers
{
    public class LegalFormController : Controller
    {
        private readonly ILegalFormService _legalFormService;
        private readonly ILegalFormConverter _legalFormConverter;

        public LegalFormController(ILegalFormService legalFormService,
           ILegalFormConverter legalFormConverter)
        {
            _legalFormService = legalFormService;
            _legalFormConverter = legalFormConverter;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var legalForms = _legalFormService.GetAll();

            var legalFormViewModels = _legalFormConverter.ConvertModelsToViewModels(legalForms);

            return View(legalFormViewModels);
        }
    }
}
