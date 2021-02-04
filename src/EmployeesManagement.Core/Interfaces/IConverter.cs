
namespace EmployeesManagement.Core.Interfaces
{
    public interface IConverter<TModel, TModelDTO>
       where TModel : class
       where TModelDTO : class
    {
        TModel ConvertDTOByModel(TModelDTO modelDTO);
        TModelDTO ConvertModelByDTO(TModel model);
    }
}
