using EmployeesManagement.Core.Interfaces.IServices;
using EmployeesManagement.Web.Interfaces;
using EmployeesManagement.Web.Interfaces.IViewConverters;
using EmployeesManagement.Web.Models.Activity;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace EmployeesManagement.Web.Controllers
{
    public class ActivityController : Controller
    {
        private readonly IActivityService _activityService;
        private readonly IActivityViewConverter _activityViewConverter;

        public ActivityController(IActivityService activityService,
            IActivityViewConverter activityViewConverter)
        {
            _activityService = activityService;
            _activityViewConverter = activityViewConverter;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var activities = _activityService.GetAll();

            var activityViewModels = _activityViewConverter.ConvertModelsToViewModels(activities);

            return View(activityViewModels);
        }
    }
}
