using System;
using System.Collections.Generic;
using System.Text;

namespace Motel.Application.Services.StageService.Dtos
{
    public class AddStage
    {
        public string Name { get; set; }

        public string Code { get; set; }

        public DateTime StageDate { get; set; }

        public List<Guid> Rooms { get; set; }
    }
}
