using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SSIP.API.Models
{
    public class FuelType
    {
        [Key]
        public int FuelTypeId { get; set; }
        public string Name { get; set; }
        public DateTime CreatedAt { get; set; }
        public bool IsDeleted { get; set; }

        [ForeignKey("FuelTypeRefId")]
        public ICollection<VehicleDetail> VehicleDetails { get; set; }
    }
}
