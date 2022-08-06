using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Motel.Core.Entities
{
    public class MotelService : BaseEntity
    {
        public Guid MotelId { get; set; }
        
        [ForeignKey(nameof(MotelId))]        
        public virtual Motel Motel { get; set; }

        public Guid ServiceId { get; set; }
        
        [ForeignKey(nameof(ServiceId))]
        public virtual Service Service { get; set; }
    }
}
