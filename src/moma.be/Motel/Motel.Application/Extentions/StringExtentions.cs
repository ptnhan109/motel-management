using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Motel.Application.Extentions
{
    public static class StringExtentions
    {
        public static string ToCurrency(this decimal value)
        {
            CultureInfo cul = CultureInfo.GetCultureInfo("vi-VN");   // try with "en-US"
            return value.ToString("#.###", cul.NumberFormat);
        }

        public static string ToCode(this int count, string prefix)
        {
            int length = (count + 1).ToString().Length;
            var builder = new StringBuilder(prefix);
            for(int i = length + 1; i < 10; i++)
            {
                builder.Append("0");
            }

            builder.Append(count+1);

            return builder.ToString();
        }
    }
}
