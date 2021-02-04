using EmployeesManagement.Core.Entities;
using EmployeesManagement.Core.Interfaces;
using EmployeesManagement.Core.Interfaces.IServices;
using EmployeesManagement.Core.Services.Common;
using System.Collections.Generic;

namespace EmployeesManagement.Core.Services
{
    public class PositionService : Service, IPositionService
    {
        public PositionService(IUnitOfWork uow) : base(uow)
        {

        }

        public IEnumerable<Position> GetAll()
        {
            return Database.Position.GetAll();
        }

        public IEnumerable<string> GetAllName()
        {
           return Database.Position.GetAllName();
        }
    }
}
