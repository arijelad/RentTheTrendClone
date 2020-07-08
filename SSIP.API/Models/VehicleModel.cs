using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SSIP.API.Models
{
    public class VehicleModel
    {
        [Key]
        public int VehicleModelId { get; set; }
        public string Name { get; set; }
        public DateTime CreatedAt { get; set; }
        public bool IsDeleted { get; set; }


        [ForeignKey("VehicleModelRefId")]
        public ICollection<VehicleBrandModel> VehicleBrandModels { get; set; }
    }
}
