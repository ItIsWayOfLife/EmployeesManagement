﻿using EmployeesManagement.Core.Entities;
using EmployeesManagement.Web.Interfaces.IConverters.Common;
using EmployeesManagement.Web.Models.LegalForm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeesManagement.Web.Interfaces.IConverters
{
    public interface ILegalFormConverter : IViewConverter<LegalForm, LegalFormViewModel>
    {

    }
}
