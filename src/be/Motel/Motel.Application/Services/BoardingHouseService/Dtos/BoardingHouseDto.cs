using Motel.Core.Entities;
using System;
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

        public int Months { get; set; }

        public int? StartDatePayment { get; set; }

        public int? EndDatePayment { get; set; }

        public Guid? CityId { get; set; }

        public IEnumerable<ServiceInHouseDto> Services { get; set; }
    }

    public class BoardingHouseDetail
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string Address { get; set; }

        public string Description { get; set; }

        public int Months { get; set; }

        public int? StartDatePayment { get; set; }

        public int? EndDatePayment { get; set; }

        public IEnumerable<ProvideInBoardingHouse> Services { get; set; }
    }

    public class BoardingHouseUpdate
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string Address { get; set; }

        public string Description { get; set; }

        public int Months { get; set; }

        public int? StartDatePayment { get; set; }

        public int? EndDatePayment { get; set; }

        public IEnumerable<ServiceInHouseDto> Services { get; set; }
    }
}
