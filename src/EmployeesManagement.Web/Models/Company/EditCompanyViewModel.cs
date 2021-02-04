using System.ComponentModel.DataAnnotations;

namespace EmployeesManagement.Web.Models.Company
{
    public class EditCompanyViewModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Укажите название")]
        [Display(Name = "Название")]
        [StringLength(50, ErrorMessage = "Недопустимая длина названия")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Укажите название органицазионно-правовой формы")]
        [Display(Name = "Органицазионно-правовая форма")]
        [StringLength(50, ErrorMessage = "Недопустимая длина названия органицазионно-правовой формы")]
        public string LegalFormName { get; set; }

        [Required(ErrorMessage = "Укажите название вида деятельности формы")]
        [Display(Name = "Вид деятельности")]
        [StringLength(50, ErrorMessage = "Недопустимая длина названия вида деятельности")]
        public string ActivityName { get; set; }
    }
}
