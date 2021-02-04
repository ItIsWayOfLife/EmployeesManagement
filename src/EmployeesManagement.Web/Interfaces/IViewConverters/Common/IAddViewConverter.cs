
namespace EmployeesManagement.Web.Interfaces.IViewConverters.Common
{
    /// <summary>
    /// Converter addViewModel to model.
    /// </summary>
    /// <typeparam name="TAddViewModel">AddViewModel.</typeparam>
    /// <typeparam name="TModel">Model.</typeparam>
    public interface IAddViewConverter<TAddViewModel, TModel>
         where TAddViewModel : class
         where TModel : class
    {
        /// <summary>
        /// Convert addViewModel to model.
        /// </summary>
        /// <param name="addViewModel">AddViewModel.</param>
        /// <returns>Model.</returns>
        public TModel ConvertAddViewModelToModel(TAddViewModel addViewModel);
    }
}
