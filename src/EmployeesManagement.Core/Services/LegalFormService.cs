using EmployeesManagement.Core.Entities;
using EmployeesManagement.Core.Interfaces;
using EmployeesManagement.Core.Interfaces.IServices;
using EmployeesManagement.Core.Services.Common;
using System.Collections.Generic;

namespace EmployeesManagement.Core.Services
{
    public class LegalFormService : Service, ILegalFormService
    {
        public LegalFormService(IUnitOfWork uow) : base(uow)
        {

        }

        public IEnumerable<LegalForm> GetAll()
        {
            return Database.LegalForm.GetAll();
        }

        public IEnumerable<string> GetAllName()
        {
            return Database.LegalForm.GetAllName();
        }
    }
}
