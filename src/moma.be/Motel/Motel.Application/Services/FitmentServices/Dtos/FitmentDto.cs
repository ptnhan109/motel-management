using System;
using System.Collections.Generic;
using System.Text;

namespace Motel.Application.Services.FitmentServices.Dtos
{
    public class FitmentDto
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public bool IsCanUse { get; set; }

        public decimal RecoupPrice { get; set; }

        public string Description { get; set; }
    }
}
