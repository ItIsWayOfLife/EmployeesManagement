using System;

namespace EmployeesManagement.Core.Entities
{
    public class Employee
    {
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Secondname { get; set; }
        public string Middlename { get; set; }
        public DateTime DateEmployment { get; set; }
        public int PositionId { get; set; }
        public Position Position { get; set; }
        public int CompanyId { get; set; }
        public Company Company { get; set; }
    }
}
