using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SSIP.API.Models
{
    public class VehicleBrandModel
    {
        [Key]
        public int VehicleBrandModelId { get; set; }

        public int VehicleBrandRefId { get; set; }
        public VehicleBrand VehicleBrand { get; set; }

        public int VehicleModelRefId { get; set; }
        public VehicleModel VehicleModel { get; set; }

        public DateTime CreatedAt { get; set; }
        public bool IsDeleted { get; set; }

        [ForeignKey("VehicleBrandModelRefId")]
        public ICollection<Vehicle> Vehicles { get; set; }
    }
}
