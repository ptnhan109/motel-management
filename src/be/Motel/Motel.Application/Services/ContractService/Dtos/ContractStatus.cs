using Motel.Common.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Motel.Application.Services.ContractService.Dtos
{
    public class ContractStatus
    {
        public Guid RoomId { get; set; }

        public EnumContractStatus Status { get; set; }

        public EnumContractType Type { get; set; }
    }
}
