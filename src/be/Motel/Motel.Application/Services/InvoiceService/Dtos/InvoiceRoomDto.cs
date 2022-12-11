using DocumentFormat.OpenXml.Drawing.Charts;
using Motel.Application.Services.ServiceService.Dtos;
using Motel.Common.Enums;
using Motel.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Motel.Application.Services.InvoiceService.Dtos
{
    public class InvoiceRoomDto
    {
        public Guid? Id { get; set; }

        public Guid StageRoomId { get; set; }

        public Guid? ProvideId { get; set; }

        public double? LastValue { get; set; }

        public double? NewValue { get; set; }

        public double Price { get; set; }

        public double? Amount { get; set; }

        public string Name { get; set; }

        public EnumServiceType ProvideType { get; set; }

        public static InvoiceRoomDto FromEntity(InvoiceRoom entity)
        {
            return new InvoiceRoomDto()
            {
                Id = entity.Id,
                Amount = entity.Amount,
                LastValue = entity.LastValue,
                Name = entity.Name,
                NewValue = entity.NewValue,
                Price = entity.Price,
                ProvideId = entity.ProvideId,
                ProvideType = entity.ProvideType,
                StageRoomId = entity.StageRoomId
            };
        }
    }
}
