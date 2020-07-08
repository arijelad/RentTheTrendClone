using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SSIP.API.Models
{
    public class Color
    {
        [Key]
        public int ColorId { get; set; }
        public string Name { get; set; }
        public DateTime CreatedAt { get; set; }
        public bool IsDeleted { get; set; }

        [ForeignKey("ColorRefId")]
        public ICollection<VehicleDetail> VehicleDetails { get; set; }
    }
}
