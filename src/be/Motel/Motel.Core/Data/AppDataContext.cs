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

        public DbSet<Provide> Services { get; set; }

        public DbSet<ServiceInBoardingHouse> ServiceInBoardingHouses { get; set; }

        public DbSet<Vehicle> Vehicles { get; set; }

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
            builder.Entity<Provide>().HasData(
                new Provide()
                {
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Id = Guid.NewGuid(),
                    Name = "Tiền nhà",
                    Type = EnumServiceType.ByMonth
                },
                new Provide()
                {
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Id = Guid.NewGuid(),
                    Name = "Tiền điện",
                    Type = EnumServiceType.ByNumber
                },
                new Provide()
                {
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Id = Guid.NewGuid(),
                    Name = "Tiền nước",
                    Type = EnumServiceType.ByNumber
                },
                new Provide()
                {
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Id = Guid.NewGuid(),
                    Name = "Xe máy",
                    Type = EnumServiceType.ByMonth
                },
                new Provide()
                {
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Id = Guid.NewGuid(),
                    Name = "Tiền xe đạp",
                    Type = EnumServiceType.ByMonth
                },
                new Provide()
                {
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Id = Guid.NewGuid(),
                    Name = "Tiền xe điện",
                    Type = EnumServiceType.ByMonth
                },
                new Provide()
                {
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Id = Guid.NewGuid(),
                    Name = "Internet",
                    Type = EnumServiceType.ByMonth
                },
                new Provide()
                {
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Id = Guid.NewGuid(),
                    Name = "Bảo vệ",
                    Type = EnumServiceType.ByMonth
                },
                new Provide()
                {
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Id = Guid.NewGuid(),
                    Name = "Máy giặt",
                    Type = EnumServiceType.ByMonth
                },
                new Provide()
                {
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Id = Guid.NewGuid(),
                    Name = "Truyền hình cáp",
                    Type = EnumServiceType.ByMonth
                },
                new Provide()
                {
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Id = Guid.NewGuid(),
                    Name = "Thang máy",
                    Type = EnumServiceType.ByMonth
                }
                );
        }
    }
}
