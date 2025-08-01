using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Vehicle
    {
        [Key]
        public int VehicleId { get; set; }
        public string Manufacturer { get; set; }
        public string Model { get; set; }
        public DateTime ProcuredDate { get; set; }

        public int SupplierId { get; set; }
        public virtual Supplier Supplier { get; set; }

        public int BranchId { get; set; }
        public virtual Branch Branch { get; set; }

        public int ClientId { get; set; }
        public virtual Client Client { get; set; }

        public int DriverId { get; set; }
        public virtual Driver Driver { get; set; }
    }
}