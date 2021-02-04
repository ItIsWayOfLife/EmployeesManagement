using EmployeesManagement.Core.Entities;
using EmployeesManagement.Web.Interfaces.IViewConverters;
using EmployeesManagement.Web.Models.Activity;
using System.Collections.Generic;

namespace EmployeesManagement.Web.Converters
{
    public class ActivityViewConverter : IActivityViewConverter
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
