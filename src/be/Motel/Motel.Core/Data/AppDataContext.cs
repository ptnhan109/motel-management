using Microsoft.EntityFrameworkCore;
using Motel.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Motel.Core.Data
{
    public class AppDataContext : DbContext
    {
        public AppDataContext(DbContextOptions opts) : base(opts)
        {

        }
        public DbSet<AppUser> Users { get; set; }
    }
}
