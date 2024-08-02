using DocumentFormat.OpenXml.Office2010.ExcelAc;
using Microsoft.EntityFrameworkCore;
using Motel.Application.Services.DashboardService.Dtos;
using Motel.Common.Constants;
using Motel.Common.Enums;
using Motel.Common.Extensions;
using Motel.Common.Generics;
using Motel.Core;
using Motel.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Motel.Application.Services.DashboardService
{
    public class ReportService : Service, IReportService
    {
        private readonly IRepository _repository;

        public ReportService(IRepository repository)
        {
            _repository = repository;
        }
        public async Task<Response> DashboardSummary()
        {
            //TODO: 
            var query = _repository.GetQueryable<Room>();
            var total = await query.CountAsync();
            var hired = await query.CountAsync(x => x.Status.Equals(EnumRoomStatus.Hired));
            var deposited = await query.CountAsync(x => x.Status.Equals(EnumRoomStatus.Deposited));
            var pending = await query.CountAsync(x => x.Status.Equals(EnumRoomStatus.Pending));

            return Ok(new SummaryDto()
            {
                TotalRoomHired = hired,
                TotalRoomDeposited = deposited,
                TotalRoomPending = pending,
                TotalRooms = total
            });
        }

        public async Task<Response> LastestPayentAsync()
        {
            var data = new LastestPayment()
            {
                Name = string.Empty,
                DebtAmount = 0,
                PaidAmount = 0,
                TotalAmount = 0
            };

            var entity = await _repository.GetQueryable<StagePayment>().OrderByDescending(x => x.StageDate)
                .FirstOrDefaultAsync();
            if (entity is null) return Ok(data);

            data.Name = entity.Name;
            data.TotalAmount = entity.TotalAmount;
            data.PaidAmount = entity.AmountPaid;
            data.DebtAmount = entity.TotalAmount - entity.AmountPaid;

            return Ok(data);
        }

        public async Task<Response> GetPaymentStageAsync()
        {
            var currentYear = new DateTime(DateTime.Now.Year, 1, 1);
            var payments = await _repository.GetQueryable<StagePayment>()
                .Where(x => x.CreatedAt >= currentYear)
                .OrderBy(x => x.StageDate).ToListAsync();

            var data = payments.Select(x => new ChartItem()
            {
                Label = x.StageDate.ToString("dd-MM-yyyy"),
                Value = x.TotalAmount
            });

            return Ok(data.ToList());
        }

        public async Task<Response> GetStagePaymentReportAsync(DateTime fromDate, DateTime toDate)
        {
            var data = await _repository.GetQueryable<StageRoom>(new string[] { "Room", "Room.BoardingHouse" })
                .Where(x => x.CreatedAt >= fromDate && x.CreatedAt <= toDate)
                .ToListAsync();

            return Ok(data);
        }

        public async Task<Response> RevenueReportAsync(DateTime fromDate, DateTime toDate, Guid? boardingHouseId)
        {
            // Lấy danh sách phòng
            var roomQuery = _repository.GetQueryable<Room>();
            if (boardingHouseId.HasValue) roomQuery = roomQuery.Where(x => x.BoardingHouseId.Equals(boardingHouseId));
            var rooms = await roomQuery.ToListAsync();

            // Lấy dữ liệu hóa đơn
            var from = new DateTime(fromDate.Year, fromDate.Month, NumberConstants.One);
            var to = new DateTime(toDate.AddMonths(NumberConstants.One).Year, toDate.AddMonths(NumberConstants.One).Month, NumberConstants.One);
            var invoices = await _repository.GetQueryable<StagePayment>( new string[] { "StageRooms" })
                .Where(x => x.StageDate >= from && x.StageDate < to).ToListAsync();

            // Xử lý dữ liệu theo phòng, tháng
            var months = new List<DateTime>();
            var vietnamesMonths = new List<string>();
            for (DateTime date = from; date < to; date = date.AddMonths(1))
            {
                months.Add(date);
                vietnamesMonths.Add(date.ToVietnameseMonth());
            }

            var data = new List<RevenueReportItem>();
            rooms.ForEach(room =>
            {
                var item = new RevenueReportItem() { RoomName = room.Name };
                var roomItems = new List<RoomRevenueReportItem>();
                months.ForEach(month =>
                {
                    
                    var invoicesInMonth = invoices.Where(x => x.StageDate.Month.Equals(month.Month) && x.StageDate.Year.Equals(month.Year));
                    decimal amount = NumberConstants.Zero;
                    foreach(var invoiceInMonth in invoicesInMonth)
                    {
                        amount += invoiceInMonth.StageRooms.Where(x => x.RoomId.Equals(room.Id)).Sum(x => x.TotalAmount);
                    }

                    roomItems.Add(new RoomRevenueReportItem()
                    {
                        MonthName = month.ToVietnameseMonth(),
                        Amount = amount
                    });
                });

                item.Items = roomItems;

                data.Add(item);
            });

            var totals = new List<decimal>();
            months.ForEach(month =>
            {
                var total = invoices.Where(x => x.StageDate.Month.Equals(month.Month) && x.StageDate.Year.Equals(month.Year)).Sum(x => x.TotalAmount);
                totals.Add(total);
            });

            return Ok(new RevenueReport()
            {
                Months = vietnamesMonths,
                Items = data,
                Totals = totals
            });
        }
    }
}
