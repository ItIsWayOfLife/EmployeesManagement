using EmployeesManagement.Core.DTOs;
using EmployeesManagement.Core.Entities;
using EmployeesManagement.Core.Interfaces;
using EmployeesManagement.Core.Interfaces.IServices;
using EmployeesManagement.Core.Services.Common;
using System;
using System.Collections.Generic;

namespace EmployeesManagement.Core.Services
{
    public class CompanyService : Service, ICompanyService
    {
        private readonly IConverter<Company, CompanyDTO> _converterCompany;

        public CompanyService(IUnitOfWork uow,
             IConverter<Company, CompanyDTO> converterCompany) : base(uow)
        {
            _converterCompany = converterCompany;
        }

        public CompanyDTO Get(int id)
        {
            var company = Database.Company.Get(id);

            var companyDTO = ConvertCompanyToCompanyDTO(company);

            return companyDTO;
        }

        public IEnumerable<CompanyDTO> GetAll()
        {
            var companies = Database.Company.GetAll();

            var companyDTOs = new List<CompanyDTO>();

            foreach (var company in companies)
            {
                companyDTOs.Add(ConvertCompanyToCompanyDTO(company));
            }

            return companyDTOs;
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

        /// <summary>
        ///  Convert company model to companyDTO model.
        /// </summary>
        /// <param name="company">Model company.</param>
        /// <returns>Model companyDTO.</returns>
        private CompanyDTO ConvertCompanyToCompanyDTO(Company company)
        {
            company.LegalForm = Database.LegalForm.Get(company.LegalFormId);
            company.Activity = Database.Activity.Get(company.ActivityId);

            var companyDTO = _converterCompany.ConvertModelByDTO(company);

            companyDTO.Size = Database.Company.GetCurrentSizeByCompanyId(company.Id);

            return companyDTO;
        }
    }
}
