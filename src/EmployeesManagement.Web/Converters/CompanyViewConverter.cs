using EmployeesManagement.Core.DTOs;
using EmployeesManagement.Web.Interfaces.IViewConverters;
using EmployeesManagement.Web.Models.Company;
using System.Collections.Generic;

namespace EmployeesManagement.Web.Converters
{
    public class CompanyViewConverter : ICompanyViewConverter
    {
        public IEnumerable<CompanyViewModel> ConvertModelsToViewModels(IEnumerable<CompanyDTO> models)
        {
            var companiesViews = new List<CompanyViewModel>();

            foreach (var companyDTO in models)
            {
                companiesViews.Add(new CompanyViewModel()
                {
                    Id = companyDTO.Id,
                    Size = companyDTO.Size,
                    LegalFormName = companyDTO.LegalFormName,
                    Name = companyDTO.Name,
                    ActivityName = companyDTO.ActivityName
                });
            }

            return companiesViews;
        }

        public CompanyDTO ConvertAddViewModelToModel(AddCompanyViewModel model)
        {
            return new CompanyDTO()
            {
                Name = model.Name,
                ActivityName = model.ActivityName,
                LegalFormName = model.LegalFormName
            };
        }

        public CompanyDTO ConvertEditViewModelToModel(EditCompanyViewModel editViewModel)
        {
            return new CompanyDTO()
            {
                Id = editViewModel.Id,
                ActivityName = editViewModel.ActivityName,
                LegalFormName = editViewModel.LegalFormName,
                Name = editViewModel.Name
            };
        }

        public EditCompanyViewModel ConvertModelToEditViewModel(CompanyDTO model)
        {
            return new EditCompanyViewModel()
            {
                Id = model.Id,
                Name = model.Name,
                LegalFormName = model.LegalFormName,
                ActivityName = model.ActivityName
            };
        }
    }
}
