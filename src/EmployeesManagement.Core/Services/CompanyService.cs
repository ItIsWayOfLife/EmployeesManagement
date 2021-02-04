using EmployeesManagement.Core.DTOs;
using EmployeesManagement.Core.Interfaces;
using EmployeesManagement.Core.Interfaces.IServices;
using EmployeesManagement.Core.Services.Common;
using System;
using System.Collections.Generic;

namespace EmployeesManagement.Core.Services
{
    public class CompanyService : Service, ICompanyService
    {
        public CompanyService(IUnitOfWork uow) : base(uow)
        {

        }

        public CompanyDTO Get(int id)
        {
            var company = Database.Company.Get(id);

            throw new NotImplementedException();
        }

        public IEnumerable<CompanyDTO> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Add(CompanyDTO model)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void Edit(CompanyDTO model)
        {
            throw new NotImplementedException();
        }

    }
}
