using EmployeesManagement.Core.Entities;
using EmployeesManagement.Web.Interfaces.IConverters;
using EmployeesManagement.Web.Models.LegalForm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeesManagement.Web.Converters
{
    public class LegalFormConverter : ILegalFormConverter
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
