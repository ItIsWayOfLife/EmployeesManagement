using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeesManagement.Web.Interfaces.IViewConverters.Common
{
    public interface IViewConverter<TModel, TViewModel>
         where TModel : class
         where TViewModel : class
    {
        public IEnumerable<TViewModel> ConvertModelsToViewModels(IEnumerable<TModel> models);
    }
}
