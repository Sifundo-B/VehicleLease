using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class VehicleReportViewModel
    {
        public string Supplier { get; set; }
        public string Branch { get; set; }
        public string Client { get; set; }
        public string Manufacturer { get; set; }
        public int Count { get; set; }
    }
}