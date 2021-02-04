using EmployeesManagement.Core.Interfaces.IServices;
using EmployeesManagement.Web.Interfaces;
using EmployeesManagement.Web.Interfaces.IConverters;
using EmployeesManagement.Web.Models.Activity;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace EmployeesManagement.Web.Controllers
{
    public class ActivityController : Controller
    {
        private readonly IActivityService _activityService;
        private readonly IActivityConverter _activityConverter;

        public ActivityController(IActivityService activityService,
            IActivityConverter activityConverter)
        {
            _activityService = activityService;
            _activityConverter = activityConverter;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var activities = _activityService.GetAll();

            var activityViewModels = _activityConverter.ConvertModelsToViewModels(activities);

            return View(activityViewModels);
        }
    }
}
