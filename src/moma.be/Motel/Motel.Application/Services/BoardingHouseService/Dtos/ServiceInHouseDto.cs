using Motel.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Motel.Application.Services.BoardingHouseService.Dtos
{
    public class ServiceInHouseDto
    {
        public Guid ServiceId { get; set; }

        public Guid BoardingHouseId { get; set; }

        public decimal Price { get; set; }

        public ProvideInBoardingHouse ToEntity(Guid id) => new ProvideInBoardingHouse()
        {
            Id = Guid.NewGuid(),
            BoardingHouseId = id,
            CreatedAt = DateTime.Now,
            Price = Price,
            ProvideId = ServiceId,
            UpdatedAt = DateTime.Now
        };
    }
}
