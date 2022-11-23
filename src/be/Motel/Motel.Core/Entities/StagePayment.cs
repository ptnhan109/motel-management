using System;
using System.Collections.Generic;
using System.Text;

namespace Motel.Core.Entities
{
    public class StagePayment : BaseEntity
    {
        public string InvoiceNo { get; set; }

        public string Name { get; set; }

        public DateTime StageDate { get; set; }

        public bool IsComplete { get; set; }
    }
}
