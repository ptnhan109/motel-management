using System;
using System.Collections.Generic;
using System.Text;

namespace Motel.Core.Entities
{
    public class Motel : BaseEntity
    {
        public string Name { get; set; }

        public string Address { get; set; }

        public string Description { get; set; }

        public int DateRetalPayment { get; set; }
    }
}
