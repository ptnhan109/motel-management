﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Motel.Application.Services.BoardingHouseService.Dtos
{
    public class BoardingHouseDto
    {
        public Guid? Id { get; set; }
        public string Name { get; set; }

        public string Address { get; set; }

        public string Description { get; set; }

        public int? DateRetailPayment { get; set; }

        public Guid? CityId { get; set; }

        public IEnumerable<ServiceInHouseDto> Services { get; set; }
    }
}