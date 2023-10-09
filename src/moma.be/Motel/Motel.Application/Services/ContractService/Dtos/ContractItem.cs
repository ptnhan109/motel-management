using Motel.Common.Enums;
using Motel.Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Motel.Application.Services.ContractService.Dtos
{
    public class ContractItem
    {
        public Guid Id { get; set; }

        public Guid? CustomerId { get; set; }

        public string Name { get; set; }

        public string CustomerName { get; set; }

        public string CustomerPhone { get; set; }

        public Guid RoomId { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime? ExpiredDate { get; set; }

        public double DepositedAmount { get; set; }

        public EnumContractType Type { get; set; }

        public int? ContractDuration { get; set; }

        public EnumContractStatus Status { get; set; }

        public static ContractItem FromEntity(AppContract entity)
            => new ContractItem()
            {
                Id = entity.Id,
                ContractDuration = entity.ContractDuration,
                CreatedDate = entity.CreatedDate,
                CustomerId = entity.CustomerId,
                CustomerName = entity.CustomerName,
                DepositedAmount = entity.DepositedAmount,
                CustomerPhone = entity.CustomerPhone,
                ExpiredDate = entity.ExpiredDate,
                Name = entity.Name,
                RoomId = entity.RoomId,
                Status = entity.Status,
                Type = entity.Type
            };
    }
}
