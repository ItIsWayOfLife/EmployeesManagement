using System.Collections.Generic;

namespace EmployeesManagement.Core.Interfaces.IServices.Common
{
    public interface IGetAllService<T> where T : class
    {
        public IEnumerable<T> GetAll();
    }
}
