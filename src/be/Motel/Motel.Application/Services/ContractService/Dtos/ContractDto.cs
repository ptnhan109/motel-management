using Motel.Common.Enums;
using Motel.Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Motel.Application.Services.ContractService.Dtos
{
    public class ContractDto
    {
        public Guid? Id { get; set; }

        public string Name { get; set; }

        public Guid? CustomerId { get; set; }

        public string CustomerName { get; set; }

        public string CustomerPhone { get; set; }

        public Guid RoomId { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime ExpiredDate { get; set; }

        public double DepositedAmount { get; set; }

        public EnumContractType Type { get; set; }

        public int? ContractDuration { get; set; }

        public IEnumerable<AddTermDto> Terms { get; set; }

        public static ContractDto FromDeposited(RoomDeposited deposited)
        {
            return new ContractDto()
            {
                ContractDuration = null,
                CreatedDate = deposited.DateStart,
                ExpiredDate = deposited.DateEnd,
                CustomerId = null,
                CustomerName = deposited.Name,
                DepositedAmount = deposited.DespositedValue,
                Id = Guid.NewGuid(),
                RoomId = deposited.RoomId,
                Type = EnumContractType.Deposited,
                CustomerPhone = deposited.Phone,
                Name = $"Hợp đồng đặt cọc phòng {deposited?.Room?.Name}"
            };
        }
    }
}
