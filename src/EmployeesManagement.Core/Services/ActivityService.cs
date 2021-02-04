using EmployeesManagement.Core.Entities;
using EmployeesManagement.Core.Interfaces;
using EmployeesManagement.Core.Interfaces.IServices;
using EmployeesManagement.Core.Services.Common;
using System.Collections.Generic;

namespace EmployeesManagement.Core.Services
{
    public class ActivityService : Service, IActivityService
    {
        public ActivityService(IUnitOfWork uow) : base(uow)
        {

        }

        public IEnumerable<Activity> GetAll()
        {
            return Database.Activity.GetAll();
        }
    }
}
