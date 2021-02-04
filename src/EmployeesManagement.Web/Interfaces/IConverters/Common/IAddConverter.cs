using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeesManagement.Web.Interfaces.IConverters.Common
{
    public interface IAddConverter<TAddViewModel, TModel>
         where TAddViewModel : class
         where TModel : class
    {
        public TModel ConvertAddViewModelToModel(TAddViewModel model);
    }
}
