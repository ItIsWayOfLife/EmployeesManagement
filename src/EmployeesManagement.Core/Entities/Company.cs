
namespace EmployeesManagement.Core.Entities
{
    public class Company
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int LegalFormId { get; set; }
        public LegalForm LegalForm { get; set; }
        public int ActivityId { get; set; }
        public Activity Activity { get; set; }
    }
}
