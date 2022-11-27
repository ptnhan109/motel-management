using Motel.Application.Services.ContractService.Dtos;
using Motel.Application.Services.ServiceService.Dtos;
using Motel.Application.Services.StageService.Dtos;
using Motel.Common.Enums;
using Motel.Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace Motel.Application.Services.InvoiceService.Dtos
{
    public class InvoiceDto
    {
        public Guid Id { get; set; }

        public ContractDto Contract { get; set; }

        public StageRoomDto Invoice { get; set; }

        public IEnumerable<InvoiceRoomDto> Items { get; set; }

        public static InvoiceDto FromEntity(StageRoom entity)
        {
            var stageRoom = StageRoomDto.FromEntity(entity);
            var items = entity.InvoiceRooms.Select(invoice => InvoiceRoomDto.FromEntity(invoice));
            return new InvoiceDto()
            {
                Id = entity.Id,
                Items = items,
                Invoice = stageRoom
            };
        }
    }
}
