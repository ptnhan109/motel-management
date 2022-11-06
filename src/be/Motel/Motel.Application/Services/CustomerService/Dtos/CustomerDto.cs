using Motel.Common.Enums;
using Motel.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Motel.Application.Services.CustomerService.Dtos
{

    public class CustomerItem
    {
        public Guid? Id { get; set; }

        public string Name { get; set; }

        public string Phone { get; set; }

        public string Room { get; set; }

        public Guid? RoomId { get; set; }

        public Guid? BoardingHouseId { get; set; }

        public string BoardingHouseName { get; set; }

        public string AvatarPath { get; set; }

        public EnumCareer? Career { get; set; }
        public static CustomerItem FromEntity(Customer customer)
        {
            return new CustomerItem()
            {
                Id = customer.Id,
                Phone = customer.Phone,
                Room = customer.Room?.Name,
                RoomId = customer.RoomId,
                BoardingHouseId = customer?.Room?.BoardingHouseId,
                BoardingHouseName = customer?.Room?.BoardingHouse.Name,
                Name = customer.Name,
                AvatarPath = customer.AvatarPath,
                Career = customer.Career
            };
        }
    }
}
