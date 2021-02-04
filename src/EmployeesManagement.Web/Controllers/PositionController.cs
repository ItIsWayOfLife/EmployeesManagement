using EmployeesManagement.Core.Interfaces.IServices;
using EmployeesManagement.Web.Models.Position;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeesManagement.Web.Controllers
{
    public class PositionController : Controller
    {
        private readonly IPositionService _positionService;

        public PositionController(IPositionService positionService)
        {
            _positionService = positionService;
        }

        public IActionResult Index()
        {
            var models = _positionService.GetAll();

            var positionViewModels = new List<PositionViewModel>();

            foreach (var model in models)
            {
                positionViewModels.Add(new PositionViewModel()
                {
                    Id = model.Id,
                    Name = model.Name
                });
            }

            return View(positionViewModels);
        }
    }
}
