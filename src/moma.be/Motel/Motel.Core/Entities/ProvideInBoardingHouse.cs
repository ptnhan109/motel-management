using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Motel.Core.Entities
{
    public class ProvideInBoardingHouse : BaseEntity
    {
        public Guid BoardingHouseId { get; set; }
        
        [ForeignKey(nameof(BoardingHouseId))]        
        public virtual BoardingHouse BoardingHouse { get; set; }

        public Guid ProvideId { get; set; }
        
        [ForeignKey(nameof(ProvideId))]
        public virtual Provide Provide { get; set; }

        public decimal Price { get; set; }
    }
}
