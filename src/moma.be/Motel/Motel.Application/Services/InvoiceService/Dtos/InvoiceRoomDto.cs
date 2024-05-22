using DocumentFormat.OpenXml.Drawing.Charts;
using Motel.Application.Services.ServiceService.Dtos;
using Motel.Common.Enums;
using Motel.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Motel.Application.Services.InvoiceService.Dtos
{
    public class CheckOutInfo
    {
        public decimal RemainAmount { get; set; }

        public decimal Amount { get; set; }

        public decimal DipositedAmount { get; set; }

        public decimal NeedGiveAmount { get; set; }

    }
    public class InvoiceRoomDto
    {
        public Guid? Id { get; set; }

        public Guid StageRoomId { get; set; }

        public Guid? ProvideId { get; set; }

        public decimal? LastValue { get; set; }

        public decimal? NewValue { get; set; }

        public decimal Price { get; set; }

        public decimal? Amount { get; set; }

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
