using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Motel.Application.Extentions
{
    public static class StringExtentions
    {
        public static string ToCurrency(this double value)
        {
            CultureInfo cul = CultureInfo.GetCultureInfo("vi-VN");   // try with "en-US"
            return value.ToString("#,###", cul.NumberFormat);
        }
    }
}
