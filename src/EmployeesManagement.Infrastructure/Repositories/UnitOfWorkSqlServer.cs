using EmployeesManagement.Core.Interfaces;
using EmployeesManagement.Core.Interfaces.IRepositories;
using Microsoft.Extensions.Configuration;
using System;
using System.Data.SqlClient;

namespace EmployeesManagement.Infrastructure.Repositories
{
    public class UnitOfWorkSqlServer : IUnitOfWork
    {
        private readonly IConfiguration _configuration;

        private SqlConnection _context { get; set; }
        private SqlTransaction _transaction { get; set; }

        private CompanyRepository _companyRepository;
        private EmployeeRepository _employeeRepository;
        private LegalFormRepository _legalFormRepositories;
        private PositionRepository _positionRepository;
        private ActivityRepository _activityRepository;

        public UnitOfWorkSqlServer(IConfiguration configuration)
        {
            _configuration = configuration;

            _context = new SqlConnection(_configuration.GetConnectionString("CatalogConnection"));
            _context.Open();

            _transaction = _context.BeginTransaction();
        }

        public IActivityRepository Activity
        {
            get
            {
                if (_activityRepository == null)
                {
                    _activityRepository = new ActivityRepository(_context, _transaction);
                }
                return _activityRepository;
            }
        }

        public ICompanyRepository Company
        {
            get
            {
                if (_companyRepository == null)
                {
                    _companyRepository = new CompanyRepository(_context, _transaction);
                }
                return _companyRepository;
            }
        }

        public IEmployeeRepository Employee
        {
            get
            {
                if (_employeeRepository == null)
                {
                    _employeeRepository = new EmployeeRepository(_context, _transaction);
                }
                return _employeeRepository;
            }
        }

        public ILegalFormRepository LegalForm
        {
            get
            {
                if (_legalFormRepositories == null)
                {
                    _legalFormRepositories = new LegalFormRepository(_context, _transaction);
                }
                return _legalFormRepositories;
            }
        }

        public IPositionRepository Position
        {
            get
            {
                if (_positionRepository == null)
                {
                    _positionRepository = new PositionRepository(_context, _transaction);
                }
                return _positionRepository;
            }
        }

        public void Dispose()
        {
            if (_transaction != null)
            {
                _transaction.Dispose();
            }

            if (_context != null)
            {
                _context.Close();
                _context.Dispose();
            }

            _employeeRepository = null;
            _companyRepository = null;
            _legalFormRepositories = null;
            _positionRepository = null;
            _activityRepository = null;

            GC.SuppressFinalize(this);
        }

        public void Save()
        {
            _transaction.Commit();
        }
    }
}
