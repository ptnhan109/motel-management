using System;
using System.Collections.Generic;
using System.Text;

namespace Motel.Common.Enums
{
    public static class EnumExtentions
    {
        public static string GetName(this EnumServiceType input)
        {
            switch (input)
            {
                case EnumServiceType.ByCustomer:
                    return "Thu theo khách thuê";
                case EnumServiceType.ByQuantity:
                    return "Thu theo số lượng";
                case EnumServiceType.ByMonth:
                    return "Thu theo phòng / tháng";
                case EnumServiceType.ByNumber:
                    return "Thu theo số đồng hồ";
                default:
                    return string.Empty;
            }
        }
    }
}
