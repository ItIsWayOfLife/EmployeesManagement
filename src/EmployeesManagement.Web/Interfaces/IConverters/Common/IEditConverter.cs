using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeesManagement.Web.Interfaces.IConverters.Common
{
    public interface IEditConverter<TEditViewModel, TModel>
         where TEditViewModel : class
        where TModel : class
    {
        public TEditViewModel ConvertModelToEditViewModel(TModel model);
        public TModel ConvertEditViewModelToModel(TEditViewModel editViewModel);
    }
}
