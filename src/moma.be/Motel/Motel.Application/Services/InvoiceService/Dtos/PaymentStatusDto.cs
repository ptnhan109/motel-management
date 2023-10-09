using Motel.Common.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Motel.Application.Services.InvoiceService.Dtos
{
    public class RoomPaymentStatusDto
    {
        public Guid StageRoomId { get; set; }

        public EnumInvoicePaymentStatus Status { get; set; }
    }
}
