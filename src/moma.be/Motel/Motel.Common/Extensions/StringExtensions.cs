using Motel.Common.Constants;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Motel.Common.Extensions
{
    public static class StringExtensions
    {
        public static string ToCurrency(this decimal value, bool? isDecimal = false)
        {
            if (value.Equals(NumberConstants.Zero))
            {
                return NumberConstants.Zero.ToString();
            }

            CultureInfo cul = CultureInfo.GetCultureInfo("vi-VN");
            if (!isDecimal.Value)
            {
                return value.ToString("#,###", cul.NumberFormat);
            }

            return value.ToString("#,###.##", cul.NumberFormat);
        }
    }
}
