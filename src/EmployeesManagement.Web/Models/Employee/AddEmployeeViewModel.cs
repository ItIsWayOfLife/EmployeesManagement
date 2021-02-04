using System;
using System.ComponentModel.DataAnnotations;

namespace EmployeesManagement.Web.Models.Employee
{
    public class AddEmployeeViewModel
    {
        [Required(ErrorMessage = "Укажите имя")]
        [Display(Name = "Имя")]
        [StringLength(50, ErrorMessage = "Недопустимая длина имени")]
        public string Firstname { get; set; }

        [Required(ErrorMessage = "Укажите фамилию")]
        [Display(Name = "Фамилию")]
        [StringLength(50, ErrorMessage = "Недопустимая длина фамилии")]
        public string Secondname { get; set; }

        [Display(Name = "Отчество")]
        [StringLength(50, ErrorMessage = "Недопустимая длина отчества")]
        public string Middlename { get; set; }

        [Required(ErrorMessage = "Укажите дату принятия на работу")]
        [Display(Name = "Дата принятия на работу")]
        public DateTime DateEmployment { get; set; }

        [Required(ErrorMessage = "Укажите должность")]
        [Display(Name = "Должность")]
        [StringLength(50, ErrorMessage = "Недопустимая длина должности")]
        public string PositionName { get; set; }

        [Required(ErrorMessage = "Укажите компанию")]
        [Display(Name = "Компания")]
        [StringLength(50, ErrorMessage = "Недопустимая длина компании")]
        public string CompanyName { get; set; }
    }
}
