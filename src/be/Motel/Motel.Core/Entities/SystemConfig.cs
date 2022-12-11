using System;
using System.Collections.Generic;
using System.Text;

namespace Motel.Core.Entities
{
    public class SystemConfig : BaseEntity
    {
        public string GroupKey { get; set; }

        public string Group { get; set; }

        public string Name { get; set; }

        public string Value { get; set; }
    }
}
