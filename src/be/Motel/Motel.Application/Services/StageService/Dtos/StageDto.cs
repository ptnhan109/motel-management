using Motel.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Motel.Application.Services.StageService.Dtos
{
    public class StageDto
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public static StageDto FromEntity(StagePayment stage)
            => new StageDto()
            {
                Id = stage.Id,
                Name = stage.Name
            };
    }
}
