using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;
using System.Data.Entity;

namespace WebApplication1.Controllers
{
    public class ReportsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        public ActionResult Index()
        {
            var report = db.Vehicles
        .Include(v => v.Supplier)
        .Include(v => v.Branch)
        .Include(v => v.Client)
        .Include(v => v.Driver) 
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
            Count = g.Count(),
            Driver = g.FirstOrDefault().Driver.FullName,
            ProcuredDate = g.FirstOrDefault().ProcuredDate
        })
        .ToList();

            return View(report);
        }
    }
}