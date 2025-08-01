using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class ReportsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        public ActionResult Index()
        {
            var report = db.Vehicles
               .GroupBy(v => new
               {
                   SupplierName = v.Supplier.Name,
                   BranchName = v.Branch.Name,
                   ClientName = v.Client.CompanyName,
                   Manufacturer = v.Manufacturer
               })
.Select(g => new VehicleReportViewModel
{
    Supplier = g.Key.SupplierName,
    Branch = g.Key.BranchName,
    Client = g.Key.ClientName,
    Manufacturer = g.Key.Manufacturer,
    Count = g.Count()
}).ToList();


            return View(report);
        }
    }
}