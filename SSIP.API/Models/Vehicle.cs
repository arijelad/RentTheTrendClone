using System;
using System.ComponentModel.DataAnnotations;

namespace SSIP.API.Models
{
    public class Vehicle
    {
        [Key]
        public int VehicleId { get; set; }

        public int VehicleBrandModelRefId { get; set; }
        public VehicleBrandModel VehicleBrandModel { get; set; }

        public int VehicleDetailRefId { get; set; }
        public VehicleDetail VehicleDetail { get; set; }

        public string Description { get; set; }
        public string Name { get; set; }
        public DateTime CreatedAt { get; set; }
        public bool IsDeleted { get; set; }
    }
}
