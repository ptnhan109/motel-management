using Motel.Common.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Motel.Core.Entities
{
    public class Service : BaseEntity
    {
        public string Name { get; set; }

        public int UnitId { get; set; }

        public EnumServiceType Type { get; set; }
    }
}
