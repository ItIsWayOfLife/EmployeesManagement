using EmployeesManagement.Core.Interfaces.IServices;
using EmployeesManagement.Web.Interfaces.IConverters;
using Microsoft.AspNetCore.Mvc;

namespace EmployeesManagement.Web.Controllers
{
    public class PositionController : Controller
    {
        private readonly IPositionService _positionService;
        private readonly IPositionConverter _positionConverter;

        public PositionController(IPositionService positionService,
            IPositionConverter positionConverter)
        {
            _positionService = positionService;
            _positionConverter = positionConverter;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var positions = _positionService.GetAll();

            var positionViewModels = _positionConverter.ConvertModelsToViewModels(positions);

            return View(positionViewModels);
        }
    }
}
