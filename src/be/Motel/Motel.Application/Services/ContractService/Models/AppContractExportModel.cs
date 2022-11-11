using Motel.Application.Extentions;
using Motel.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Motel.Application.Services.ContractService.Models
{
    public class AppContractExportModel
    {
        public string ContractName { get; set; }

        public string OwnerName { get; set; }

        public string OwnerDayOfBirth { get; set; }

        public string OwnerIdentityNumber { get; set; }

        public string OwnerIdentityDate { get; set; }

        public string OwnerIdentityProvider { get; set; }

        public string OwnerAddress { get; set; }

        public string CustomerName { get; set; }

        public string CustomerDayOfBirth { get; set; }

        public string CustomerIdentityNumber { get; set; }

        public string CustomerIdentityDate { get; set; }

        public string CustomerIdentityProvider { get; set; }

        public string CustomerAddress { get; set; }

        public string BoardingAddress { get; set; }

        public string Month { get; set; }

        public string StartDate { get; set; }

        public string RoomPrice { get; set; }

        public string DatePrice { get; set; }

        public string DepositedPrice { get; set; }

        public string ContractAddress { get; set; }

        public string ContractDate { get; set; }

        public string ContractMonth { get; set; }

        public string ContractYear { get; set; }

        public AppContractExportModel(UserInfo userInfo, Customer customer, AppContract contract, Room room)
        {
            ContractName = contract.Name;

            OwnerName = userInfo.Name;
            OwnerIdentityNumber = userInfo.IdentityNumber;
            OwnerDayOfBirth = userInfo?.DayOfBirth?.ToString("dd/MM/yyyy") ?? string.Empty;
            OwnerIdentityDate = userInfo?.IdentityDate ?? string.Empty;
            OwnerIdentityProvider = userInfo?.IdentityProvider ?? string.Empty;
            OwnerAddress = userInfo?.Address ?? string.Empty;

            CustomerName = customer?.Name;
            CustomerAddress = customer.Address;
            CustomerIdentityNumber = customer.IdentificationCitizen;
            CustomerIdentityProvider = string.Empty;
            CustomerDayOfBirth = customer.BirthDay.ToString("dd/MM/yyyy");
            CustomerIdentityDate = string.Empty;

            BoardingAddress = room?.BoardingHouse?.Address ?? string.Empty;
            Month = contract.ContractDuration?.ToString() ?? string.Empty;
            StartDate = contract.CreatedDate.ToString("dd/MM/yyyy");
            RoomPrice = room.Price.ToCurrency();
            DatePrice = room?.BoardingHouse?.StartDatePayment?.ToString() ?? string.Empty;
            DepositedPrice = contract.DepositedAmount.ToCurrency();

            ContractDate = contract.CreatedDate.Date.ToString("d");
            ContractYear = contract.CreatedDate.ToString("yyyy");
            ContractAddress = string.Empty;


        }
    }
}
