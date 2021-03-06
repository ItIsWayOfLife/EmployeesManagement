﻿using EmployeesManagement.Core.Entities;
using EmployeesManagement.Web.Interfaces.IViewConverters;
using EmployeesManagement.Web.Models.Position;
using System.Collections.Generic;

namespace EmployeesManagement.Web.Converters
{
    public class PositionViewConverter : IPositionViewConverter
    {
        public IEnumerable<PositionViewModel> ConvertModelsToViewModels(IEnumerable<Position> models)
        {
            var positionViewModels = new List<PositionViewModel>();

            foreach (var position in models)
            {
                positionViewModels.Add(new PositionViewModel()
                {
                    Id = position.Id,
                    Name = position.Name
                });
            }

            return positionViewModels;
        }
    }
}
