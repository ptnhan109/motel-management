using Motel.Application.Services.DashboardService.Dtos;
using Motel.Core;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Motel.Application.Services.DashboardService
{
    public class DashboardService : Service, IDashboardService
    {
        private readonly IRepository _repository;

        public DashboardService(IRepository repository)
        {
            _repository = repository;
        }
        public async Task<SummaryDto> DashboardSummary()
        {
            throw new NotImplementedException();
        }
    }
}
