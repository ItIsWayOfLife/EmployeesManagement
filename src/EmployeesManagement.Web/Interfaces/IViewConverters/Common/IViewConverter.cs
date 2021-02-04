using System.Collections.Generic;

namespace EmployeesManagement.Web.Interfaces.IViewConverters.Common
{
    /// <summary>
    /// Converter ViewModel to model.
    /// </summary>
    /// <typeparam name="TModel">Model.</typeparam>
    /// <typeparam name="TViewModel">ViewModel.</typeparam>
    public interface IViewConverter<TModel, TViewModel>
         where TModel : class
         where TViewModel : class
    {
        /// <summary>
        /// Convert models to viewModels.
        /// </summary>
        /// <param name="models">Models.</param>
        /// <returns>ViewModels.</returns>
        public IEnumerable<TViewModel> ConvertModelsToViewModels(IEnumerable<TModel> models);
    }
}
