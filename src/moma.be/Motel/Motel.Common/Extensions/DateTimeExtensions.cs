using System;
using System.Collections.Generic;
using System.Text;

namespace Motel.Common.Extensions
{
    public static class DateTimeExtensions
    {
        public static string ToTextDateFormt(this DateTime date)
        {
            return $"Ngày {date.Day} tháng {date.Month} năm {date.Year}";
        }

        public static string ToDateTimeFormat(this DateTime dateTime)
        {
            return dateTime.ToString("HH:mm dd/MM/yyyy");
        }

        public static string ToDateOnlyFormat(this DateTime dateTime) => dateTime.ToString("dd/MM/yyyy");

        public static string ToVietnameseMonth(this DateTime dateTime) => $"Tháng {dateTime.Month.ToString().PadLeft(2, '0')}";

    }
}
