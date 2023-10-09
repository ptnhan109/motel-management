using System;
using System.Collections.Generic;
using System.Text;

namespace Motel.Application.Models
{
    public class AppFilter
    {
        public string keyword { get; set; } = "";

        public int? pageIndex { get; set; } = 1;

        public int? pageSize { get; set; } = 30;
    }
}
