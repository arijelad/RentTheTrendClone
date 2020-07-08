using System;
using Microsoft.EntityFrameworkCore;
using SSIP.API.Models;

namespace SSIP.API.Data
{
    public class ApplicationDbContext : DbContext

    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Vehicle> Vehicles { get; set; }
        public DbSet<VehicleDetail> VehicleDetails { get; set; }
        public DbSet<VehicleBrand> VehicleBrands { get; set; }
        public DbSet<VehicleModel> VehicleModels { get; set; }
        public DbSet<VehicleBrandModel> VehicleBrandModels { get; set; }
        public DbSet<Color> Colors { get; set; }
        public DbSet<DriveType> DriveTypes { get; set; }
        public DbSet<FuelType> FuelTypes { get; set; }
        public DbSet<GearType> GearType { get; set; }
        public DbSet<VehicleType> VehicleTypes { get; set; }

    }
}

