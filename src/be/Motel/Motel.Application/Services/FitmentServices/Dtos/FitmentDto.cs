using System;
using System.Collections.Generic;
using System.Text;

namespace Motel.Application.Services.FitmentServices.Dtos
{
    public class FitmentDto
    {
        public string Name { get; set; }

        public bool IsCanUse { get; set; }

        public double RecoupPrice { get; set; }

        public string Description { get; set; }
    }
}
