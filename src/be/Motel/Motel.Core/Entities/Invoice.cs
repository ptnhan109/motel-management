using System;
using System.Collections.Generic;
using System.Text;

namespace Motel.Core.Entities
{
    public class Invoice : BaseEntity
    {
        public string Name { get; set; }

        public DateTime Created { get; set; }
        


    }
}
