using EmployeesManagement.Core.Interfaces.IServices;
using EmployeesManagement.Web.Models.Activity;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace EmployeesManagement.Web.Controllers
{
    public class ActivityController : Controller
    {
        private readonly IActivityService _activityService;

        public ActivityController(IActivityService activityService)
        {
            _activityService = activityService;
        }

        public IActionResult Index()
        {
            var models = _activityService.GetAll();

            var activityViewModels = new List<ActivityViewModel>();

            foreach (var model in models)
            {
                activityViewModels.Add(new ActivityViewModel()
                { 
                 Id = model.Id,
                 Name = model.Name
                });
            }

            return View(activityViewModels);
        }
    }
}
