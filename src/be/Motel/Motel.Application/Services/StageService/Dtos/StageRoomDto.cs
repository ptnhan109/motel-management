﻿using Motel.Common.Enums;
using Motel.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Motel.Application.Services.StageService.Dtos
{
    public class StageRoomDto
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public double Amount { get; set; }

        public bool IsComplete { get; set; }

        public string BoardingName { get; set; }

        public EnumInvoicePaymentStatus PaymentStatus { get; set; }

        public static StageRoomDto FromEntity(StageRoom entity)
            => new StageRoomDto()
            {
                Id = entity.Id,
                Amount = entity.TotalAmount,
                IsComplete = entity.IsCompleted,
                Name = entity.Room.Name,
                PaymentStatus = entity.PaymentStatus,
                BoardingName = entity.Room.BoardingHouse.Name
            };
    }
}