using Microsoft.EntityFrameworkCore;
using Motel.Common.Enums;
using Motel.Core.Entities;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Motel.Core.Data
{
    public class AppDataContext : DbContext
    {
        public AppDataContext(DbContextOptions opts) : base(opts)
        {

        }
        public DbSet<AppUser> Users { get; set; }

        public DbSet<City> Cities { get; set; }

        public DbSet<Customer> Customers { get; set; }

        public DbSet<Fitment> Fitments { get; set; }

        public DbSet<FitmentInRoom> FitmentInRooms { get; set; }

        public DbSet<BoardingHouse> BoardingHouses { get; set; }

        public DbSet<Room> Rooms { get; set; }

        public DbSet<RoomDeposited> RoomDepositeds { get; set; }

        public DbSet<Provide> Provides { get; set; }

        public DbSet<ProvideInBoardingHouse> ServiceInBoardingHouses { get; set; }

        public DbSet<Vehicle> Vehicles { get; set; }

        public DbSet<SystemFile> SystemFiles { get; set; }

        public DbSet<AppContract> AppContracts { get; set; }

        public DbSet<UserInfo> UserInfos { get; set; }

        public DbSet<StagePayment> StagePayments { get; set; }

        public DbSet<StageRoom> StageRooms { get; set; }

        public DbSet<InvoiceRoom> Invoices { get; set; }

        public DbSet<SystemConfig> Systems { get; set; }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<AppUser>().HasData(
                new AppUser()
                {
                    Id = Guid.NewGuid(),
                    Address = "Cổ Nhuế, Từ Liêm",
                    CreatedAt = DateTime.Now,
                    Gender = EnumGender.Male,
                    Mail = "trongnhan1110i@gmail.com",
                    Name = "Phạm Trọng Nhân",
                    Password = "T24UgcZyY5d5T538cm2QRc80DLB/e79sk97fjiJDzJw=",
                    Phone = "0775331777",
                    Role = EnumRole.Admin,
                    UpdatedAt = DateTime.Now,
                    CityId = null
                }
                );
        }
    }
}
