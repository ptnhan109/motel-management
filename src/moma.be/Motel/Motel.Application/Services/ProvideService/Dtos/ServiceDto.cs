using Motel.Common.Enums;
using Motel.Common.Helper;
using System;

namespace Motel.Application.Services.ServiceService.Dtos
{
    public class ProvideDto : ExportExcelModel
    {
        public string Name { get; set; }

        public string By { get; set; }

        public Guid Id { get; set; }

        public EnumServiceType Type { get; set; }

        public decimal DefaultPrice { get; set; }
    }

    public class ProvideModel : ExportExcelModel
    {
        public Guid? Id { get; set; }

        [Excel("Tên dịch vụ",1)]
        public string Name { get; set; }

        [Excel("Hình thức thu", 2)]
        public EnumServiceType Type { get; set; }

        [Excel("Đơn giá mặc định",3)]
        public decimal DefaultPrice { get; set; }
    }
}
