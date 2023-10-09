using Motel.Common.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Motel.Core.Entities
{
    public class Provide : BaseEntity
    {
        public string Name { get; set; }

        public EnumServiceType Type { get; set; }

        public double DefaultPrice { get; set; }
    }
}
