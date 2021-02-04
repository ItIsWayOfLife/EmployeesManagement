
namespace EmployeesManagement.Web.Interfaces.IViewConverters.Common
{
    /// <summary>
    /// Converter editViewModel to model and reverce.
    /// </summary>
    /// <typeparam name="TEditViewModel">EditViewModel.</typeparam>
    /// <typeparam name="TModel">Model.</typeparam>
    public interface IEditViewConverter<TEditViewModel, TModel>
         where TEditViewModel : class
        where TModel : class
    {
        /// <summary>
        /// Convert model to editViewModel.
        /// </summary>
        /// <param name="model">Model.</param>
        /// <returns>EditViewModel.</returns>
        public TEditViewModel ConvertModelToEditViewModel(TModel model);

        /// <summary>
        /// Convert editViewModel to model.
        /// </summary>
        /// <param name="editViewModel">EditViewModel.</param>
        /// <returns>Model.</returns>
        public TModel ConvertEditViewModelToModel(TEditViewModel editViewModel);
    }
}
