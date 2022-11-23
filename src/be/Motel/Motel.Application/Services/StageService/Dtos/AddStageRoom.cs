using Motel.Common.Enums;
using Motel.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Motel.Application.Services.StageService.Dtos
{
    public class AddStageRoom
    {
        public Guid RoomId { get; set; }

        public Guid StagePaymentId { get; set; }

        public AddStageRoom(Guid roomId, Guid stagePaymentId)
        {
            RoomId = roomId;
            StagePaymentId = stagePaymentId;
        }

        public StageRoom ToEntity()
            => new StageRoom()
            {
                Id = Guid.NewGuid(),
                CreatedAt = DateTime.Now,
                PaymentStatus = EnumInvoicePaymentStatus.None,
                RoomId = RoomId,
                StagePaymentId = StagePaymentId,
                TotalAmount = 0,
                UpdatedAt = DateTime.Now
            };
    }
}
