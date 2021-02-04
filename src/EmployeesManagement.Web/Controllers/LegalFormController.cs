using EmployeesManagement.Core.Interfaces.IServices;
using EmployeesManagement.Web.Models.LegalForm;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace EmployeesManagement.Web.Controllers
{
    public class LegalFormController : Controller
    {
        private readonly ILegalFormService _legalFormService;

        public LegalFormController(ILegalFormService legalFormService)
        {
            _legalFormService = legalFormService;
        }

        public IActionResult Index()
        {
            var models = _legalFormService.GetAll();

            var legalFormViewModels = new List<LegalFormViewModel>();

            foreach (var model in models)
            {
                legalFormViewModels.Add(new LegalFormViewModel()
                {
                    Id = model.Id,
                    Name = model.Name
                });
            }

            return View(legalFormViewModels);
        }
    }
}
