using Motel.Common.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Motel.Core.Entities
{
    public class SystemFile : BaseEntity
    {
        public Guid MapId { get; set; }

        public EnumFileType FileType { get; set; }

        public string FileName { get; set; }

        public string Extension { get; set; }

        public string Path { get; set; }
    }
}
