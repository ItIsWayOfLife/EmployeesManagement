﻿using System;

namespace EmployeesManagement.Core.DTOs
{
    public class EmployeeDTO
    {
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Secondname { get; set; }
        public string Middlename { get; set; }
        public DateTime DateEmployment { get; set; }
        public string PositionName { get; set; }
        public string CompanyName { get; set; }
    }
}
