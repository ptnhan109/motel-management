using Motel.Application.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Motel.Application.Services.StageService.Models
{
    public class RoomInStageFilterModel : AppFilter
    {
        public Guid? BoardingId { get; set; }
    }
}
