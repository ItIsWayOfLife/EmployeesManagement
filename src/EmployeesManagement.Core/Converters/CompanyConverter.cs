﻿using EmployeesManagement.Core.DTOs;
using EmployeesManagement.Core.Entities;
using EmployeesManagement.Core.Interfaces;

namespace EmployeesManagement.Core.Converters
{
    public class CompanyConverter : IConverter<Company, CompanyDTO>
    {
        public Company ConvertDTOToModel(CompanyDTO modelDTO)
        {
            return new Company()
            {
                Id = modelDTO.Id,
                Name = modelDTO.Name
            };
        }

        public CompanyDTO ConvertModelToDTO(Company model)
        {
            return new CompanyDTO()
            {
                Id = model.Id,
                Name = model.Name,
                LegalFormName = model?.LegalForm?.Name,
                ActivityName = model?.Activity?.Name
            };
        }
    }
}
