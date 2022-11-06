using Motel.Common.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Motel.Application.Services.ContractService.Dtos
{
    public class AddTermDto
    {
        public EnumTermType Type { get; set; }

        public string Content { get; set; }
    }
}
