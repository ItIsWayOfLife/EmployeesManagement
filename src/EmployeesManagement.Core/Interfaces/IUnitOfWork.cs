using EmployeesManagement.Core.Interfaces.IRepositories;
using System;

namespace EmployeesManagement.Core.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        ICompanyRepository Company { get; }
        IEmployeeRepository Employee { get; }
        ILegalFormRepository LegalForm { get; }
        IPositionRepository Position { get; }
        IActivityRepository Activity { get; }

        void Save();
    }
}
