using Motel.Application.Models;
using System;

namespace Motel.Application.Services.CustomerService.Models
{
    public class CustomerFilter : AppFilter
    {
        public Guid? BoardingHouseId { get; set; }

        public Guid? RoomId { get; set; }
    }
}
