﻿using EmployeesManagement.Core.Entities;
using EmployeesManagement.Web.Interfaces.IViewConverters;
using EmployeesManagement.Web.Models.LegalForm;
using System.Collections.Generic;

namespace EmployeesManagement.Web.Converters
{
    public class LegalFormViewConverter : ILegalFormViewConverter
    {
        public IEnumerable<LegalFormViewModel> ConvertModelsToViewModels(IEnumerable<LegalForm> models)
        {
            var legalFormViewModels = new List<LegalFormViewModel>();

            foreach (var legalForm in models)
            {
                legalFormViewModels.Add(new LegalFormViewModel()
                {
                    Id = legalForm.Id,
                    Name = legalForm.Name
                });
            }

            return legalFormViewModels;
        }
    }
}
