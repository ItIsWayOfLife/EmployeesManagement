using EmployeesManagement.Core.Interfaces.IServices;
using EmployeesManagement.Web.Interfaces.IViewConverters;
using Microsoft.AspNetCore.Mvc;

namespace EmployeesManagement.Web.Controllers
{
    public class LegalFormController : Controller
    {
        private readonly ILegalFormService _legalFormService;
        private readonly ILegalFormViewConverter _legalFormViewConverter;

        public LegalFormController(ILegalFormService legalFormService,
          ILegalFormViewConverter legalFormViewConverter)
        {
            _legalFormService = legalFormService;
            _legalFormViewConverter = legalFormViewConverter;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var legalForms = _legalFormService.GetAll();

            var legalFormViewModels = _legalFormViewConverter.ConvertModelsToViewModels(legalForms);

            return View(legalFormViewModels);
        }
    }
}
