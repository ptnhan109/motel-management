using Motel.Application.Services.BoardingHouseService.Dtos;
using Motel.Common.Generics;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Motel.Application.Services.BoardingHouseService
{
    public interface IBoardingHouseService
    {
        Task<Response> AddAsync(BoardingHouseDto request);

        Task<Response> UpdateAsync(BoardingHouseDto request);
    }
}
