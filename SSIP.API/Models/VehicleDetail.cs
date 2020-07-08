using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SSIP.API.Models
{
    public class VehicleDetail
    {
        [Key]
        public int VehicleDetailId { get; set; }

        public int ColorRefId { get; set; }
        public Color Color { get; set; }

        public int FuelTypeRefId { get; set; }
        public FuelType FuelType { get; set; }

        public int GearTypeRefId { get; set; }
        public GearType GearType { get; set; }

        public int VehicleTypeRefId { get; set; }
        public VehicleType VehicleType { get; set; }

        public int DriveTypeRefId { get; set; }
        public DriveType DriveType { get; set; }

        public double CubicCapacity { get; set; }
        public int Mileage { get; set; }
        public int NumberOfDoors { get; set; }
        public int HorsePower { get; set; }
        public int Kw { get; set; }
        public int YearOfMaking { get; set; }
        public DateTime CreatedAt { get; set; }
        public bool IsDeleted { get; set; }


        [ForeignKey("VehicleDetailRefId")]
        public ICollection<Vehicle> Vehicles { get; set; }
    }
}
