using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Driver
    {
        [Key]
        public int DriverId { get; set; }
        public string FullName { get; set; }
        public string LicenseNumber { get; set; }

        public virtual ICollection<Vehicle> Vehicles { get; set; }
    }
}