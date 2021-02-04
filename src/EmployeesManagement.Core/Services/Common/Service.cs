using EmployeesManagement.Core.Interfaces;
using System;

namespace EmployeesManagement.Core.Services.Common
{
    public abstract class Service : IDisposable
    {
        protected IUnitOfWork Database { get; set; }

        public Service(IUnitOfWork uow)
        {
            Database = uow;
        }

        public void Dispose()
        {
            Database.Dispose();
        }
    }
}
