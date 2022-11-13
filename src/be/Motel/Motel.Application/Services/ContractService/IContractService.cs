using Motel.Application.Services.ContractService.Dtos;
using Motel.Application.Services.ContractService.Models;
using Motel.Common.Generics;
using System;
using System.Threading.Tasks;

namespace Motel.Application.Services.ContractService
{
    public interface IContractService
    {
        Task<Response> AddAsync(ContractDto dto);

        Task<Response> GetContractPaging(ContractFilter filter);

        Task<byte[]> CreateContractFile(Guid id);

        Task<Response> DeleteAsync(Guid id);
    }
}
