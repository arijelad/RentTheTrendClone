using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SSIP.API.Models
{
    public class VehicleBrand
    {
        [Key]
        public int VehicleBrandId { get; set; }
        public string Name { get; set; }
        public DateTime CreatedAt { get; set; }
        public bool IsDeleted { get; set; }

        [ForeignKey("VehicleBrandRefId")]
        public ICollection<VehicleBrandModel> VehicleBrandModels { get; set; }
    }
}
