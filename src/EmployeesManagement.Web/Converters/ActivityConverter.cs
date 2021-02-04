using EmployeesManagement.Core.Entities;
using EmployeesManagement.Web.Interfaces;
using EmployeesManagement.Web.Interfaces.IConverters;
using EmployeesManagement.Web.Models.Activity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeesManagement.Web.Converters
{
    public class ActivityConverter : IActivityConverter
    {
        public IEnumerable<ActivityViewModel> ConvertModelsToViewModels(IEnumerable<Activity> models)
        {
            var activityViewModels = new List<ActivityViewModel>();

            foreach (var activity in models)
            {
                activityViewModels.Add(new ActivityViewModel()
                {
                    Id = activity.Id,
                    Name = activity.Name
                });
            }

            return activityViewModels;
        }
    }
}
