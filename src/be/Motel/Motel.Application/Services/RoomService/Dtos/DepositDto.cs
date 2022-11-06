using Motel.Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Motel.Application.Services.RoomService.Dtos
{
    public class DepositDto
    {
        public Guid RoomId { get; set; }

        public DateTime DateStart { get; set; }

        public DateTime DateEnd { get; set; }

        public double DespositedValue { get; set; }

        public string Note { get; set; }

        public string Name { get; set; }

        public string Phone { get; set; }

        public string Address { get; set; }

        public string IdentityNumber { get; set; }

        public bool? IsCreateContract { get; set; }
    }
}
