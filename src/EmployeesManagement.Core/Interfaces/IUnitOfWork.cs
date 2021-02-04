using EmployeesManagement.Core.Interfaces.IRepositories;
using System;

namespace EmployeesManagement.Core.Interfaces
{
    /// <summary>
    /// Unit work with all repositories.
    /// </summary>
    public interface IUnitOfWork : IDisposable
    {
        /// <summary>
        /// Company repository. Working DB with entity Company.
        /// </summary>
        ICompanyRepository Company { get; }

        /// <summary>
        /// Employee repository. Working DB with entity Employee.
        /// </summary>
        IEmployeeRepository Employee { get; }

        /// <summary>
        /// LegalForm repository. Working DB with entity LegalForm.
        /// </summary>
        ILegalFormRepository LegalForm { get; }

        /// <summary>
        /// Position repository. Working DB with entity Position.
        /// </summary>
        IPositionRepository Position { get; }

        /// <summary>
        /// Activity repository. Working DB with entity Activity.
        /// </summary>
        IActivityRepository Activity { get; }

        /// <summary>
        /// Save data in DB.
        /// </summary>
        void Save();
    }
}
