using Motel.Common.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Motel.Core.Entities
{
    public class Room : BaseEntity
    {
        public Guid MotelId { get; set; }

        [ForeignKey(nameof(MotelId))]
        public Motel Motel { get; set; }

        public string Name { get; set; }

        public double Price { get; set; }

        public int Floor { get; set; }

        public int MaxHuman { get; set; }

        public string Description { get; set; }

        public EnumRoomStatus Status { get; set; }

        public string Location { get; set; }
    }
}
