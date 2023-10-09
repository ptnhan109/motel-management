using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Motel.Service.Entities
{
    public class ToDo
    {
        public Guid Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public ToDo(Guid id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
