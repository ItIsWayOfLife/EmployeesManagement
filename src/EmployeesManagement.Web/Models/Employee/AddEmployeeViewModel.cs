﻿using System;

namespace EmployeesManagement.Web.Models.Employee
{
    public class AddEmployeeViewModel
    {
        public string Firstname { get; set; }
        public string Secondname { get; set; }
        public string Middlename { get; set; }
        public DateTime DateEmployment { get; set; }
        public string PositionName { get; set; }
        public string CompanyName { get; set; }
    }
}
