using Motel.Common.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Motel.Application.Services.ServiceService.Dtos
{
    public class ProvideDto
    {
        public string Name { get; set; }

        public string By { get; set; }

        public Guid Id { get; set; }

        public EnumServiceType Type { get; set; }
    }

    public class ProvideModel
    {
        public Guid? Id { get; set; }
        public string Name { get; set; }
        public EnumServiceType Type { get; set; }
    }
}
