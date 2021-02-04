using EmployeesManagement.Core.DTOs;
using EmployeesManagement.Core.Entities;
using EmployeesManagement.Core.Exceptions;
using EmployeesManagement.Core.Interfaces;
using EmployeesManagement.Core.Interfaces.IServices;
using EmployeesManagement.Core.Services.Common;
using System;
using System.Collections.Generic;

namespace EmployeesManagement.Core.Services
{
    public class CompanyService : Service, ICompanyService
    {
        private readonly IConverter<Company, CompanyDTO> _companyConverter;

        public CompanyService(IUnitOfWork uow,
             IConverter<Company, CompanyDTO> companyConverter) : base(uow)
        {
            _companyConverter = companyConverter;
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
            int legalFormId = GetLegalFormIdByLegalFormName(model.LegalFormName);
            int activityId = GetActivityIdByActivityName(model.ActivityName);

            var company = _companyConverter.ConvertDTOByModel(model);

            company.LegalFormId = legalFormId;
            company.ActivityId = activityId;

            Database.Company.Create(company);
            Database.Save();
        }

        public void Delete(int id)
        {
            Database.Company.Delete(id);
            Database.Save();
        }

        public void Edit(CompanyDTO model)
        {
            var company = Database.Company.Get(model.Id);

            if (company == null)
            {
                throw new ValidationException("Компания не найдена", string.Empty);
            }

            int legalFormId = GetLegalFormIdByLegalFormName(model.LegalFormName);
            int activityId = GetActivityIdByActivityName(model.ActivityName);

            company.LegalFormId = legalFormId;
            company.ActivityId = activityId;
            company.Name = model.Name;

            Database.Company.Update(company);
            Database.Save();
        }

        private int GetLegalFormIdByLegalFormName(string legalFormName)
        {
            int? legalFormId = Database.LegalForm.GetIdByName(legalFormName);

            if (legalFormId == null)
            {
                throw new ValidationException($"Не установлена организационно-правовая форма", string.Empty);
            }

            return legalFormId.Value;
        }

        private int GetActivityIdByActivityName(string activityName)
        {
            int? activityId = Database.Activity.GetIdByName(activityName);

            if (activityId == null)
            {
                throw new ValidationException($"Не установлен вид деятельности", string.Empty);
            }

            return activityId.Value;
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

            var companyDTO = _companyConverter.ConvertModelByDTO(company);

            companyDTO.Size = Database.Company.GetCurrentSizeByCompanyId(company.Id);

            return companyDTO;
        }

        public IEnumerable<string> GetAllName()
        {
            return Database.Company.GetAllName();
        }
    }
}
