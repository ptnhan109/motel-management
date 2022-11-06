using Motel.Application.Services.ContractService.Dtos;
using Motel.Common.Generics;
using System.Threading.Tasks;

namespace Motel.Application.Services.ContractService
{
    public interface IContractService
    {
        Task<Response> AddAsync(ContractDto dto);
    }
}
