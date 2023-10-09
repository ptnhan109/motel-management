using Motel.Application.Models;
using Motel.Common.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Motel.Application.Services.ContractService.Models
{
    public class ContractFilter : AppFilter
    {
        public EnumContractStatus? Status { get; set; }

        public EnumContractType? Type { get; set; }
    }
}
