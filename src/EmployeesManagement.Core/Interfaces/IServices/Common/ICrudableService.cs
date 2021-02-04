
namespace EmployeesManagement.Core.Interfaces.IServices.Common
{
    public interface ICrudableService<T> : IGetAllService<T> where T : class
    {
        T Get(int id);
        void Add(T model);
        void Edit(T model);
        void Delete(int id);
    }
}
