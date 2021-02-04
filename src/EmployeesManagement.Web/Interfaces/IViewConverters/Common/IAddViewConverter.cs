using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeesManagement.Web.Interfaces.IViewConverters.Common
{
    public interface IAddViewConverter<TAddViewModel, TModel>
         where TAddViewModel : class
         where TModel : class
    {
        public TModel ConvertAddViewModelToModel(TAddViewModel model);
    }
}
