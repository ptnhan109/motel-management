using Motel.Application.Services.BoardingHouseService.Dtos;
using Motel.Application.Services.ContractService.Dtos;
using Motel.Application.Services.RoomService.Dtos;
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

        public RoomDto Room { get; set; }

        public BoardingHouseDto BoardingHouse { get; set; }

        public IEnumerable<InvoiceRoomDto> Items { get; set; }

        public bool SubtractDeposited { get; set; }

        public static InvoiceDto FromEntity(StageRoom entity)
        {
            var stageRoom = StageRoomDto.FromEntity(entity);
            var items = entity.InvoiceRooms.Select(invoice => InvoiceRoomDto.FromEntity(invoice));
            var room = RoomDto.FromEntity(entity.Room);
            var boading = BoardingHouseDto.FromEntity(entity.Room.BoardingHouse);
            return new InvoiceDto()
            {
                Id = entity.Id,
                Items = items,
                Invoice = stageRoom,
                Room = room,
                BoardingHouse = boading,
                SubtractDeposited = entity.IsSubtractToDeposited
            };
        }

        private void InvoiceProcess(ref List<InvoiceRoomDto> items)
        {
            foreach (var item in items)
            {
                switch (item.ProvideType)
                {
                    //case EnumServiceType.ByMonth
                }
            }
        }
    }

}
