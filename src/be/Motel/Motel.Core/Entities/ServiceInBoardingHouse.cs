using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Motel.Core.Entities
{
    public class ServiceInBoardingHouse : BaseEntity
    {
        public Guid BoardingHouseId { get; set; }
        
        [ForeignKey(nameof(BoardingHouseId))]        
        public virtual BoardingHouse BoardingHouse { get; set; }

        public Guid ServiceId { get; set; }
        
        [ForeignKey(nameof(ServiceId))]
        public virtual Service Service { get; set; }

        public double Price { get; set; }
    }
}
