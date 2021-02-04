using EmployeesManagement.Core.Interfaces.IServices;
using EmployeesManagement.Web.Interfaces.IViewConverters;
using Microsoft.AspNetCore.Mvc;

namespace EmployeesManagement.Web.Controllers
{
    public class PositionController : Controller
    {
        private readonly IPositionService _positionService;
        private readonly IPositionViewConverter _positionViewConverter;

        public PositionController(IPositionService positionService,
            IPositionViewConverter positionViewConverter)
        {
            _positionService = positionService;
            _positionViewConverter = positionViewConverter;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var positions = _positionService.GetAll();

            var positionViewModels = _positionViewConverter.ConvertModelsToViewModels(positions);

            return View(positionViewModels);
        }
    }
}
