using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SSIP.API.Models
{
    public class VehicleType
    {
        [Key]
        public int VehicleTypeId { get; set; }
        public string Name { get; set; }
        public DateTime CreatedAt { get; set; }
        public bool IsDeleted { get; set; }

        [ForeignKey("VehicleTypeRefId")]
        public ICollection<VehicleDetail> VehicleDetails { get; set; }
    }
}
