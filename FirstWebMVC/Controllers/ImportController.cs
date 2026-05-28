using Microsoft.AspNetCore.Mvc; 
using Microsoft.EntityFrameworkCore;
using FirstWebMVC.Data;
using FirstWebMVC.Models;
using FirstWebMVC.Models.ViewModels;

namespace FirstWebMVC.Controllers
{
    public class ImportController : Controller
    {
        private readonly AppDbContext _context;

        public ImportController(AppDbContext context)
        {
            _context = context;
        }


        public IActionResult Index()
        {
            var data = _context.Imports
                .Include(x => x.ImportDetails)
                .ThenInclude(d => d.Device)
                .ToList();

            return View(data);
        }

    
        public IActionResult Create()
        {
            ViewBag.Devices = _context.Devices.ToList(); 
            return View();
        }

    
        [HttpPost]
        public IActionResult Create(ImportVM vm)
        {
            var import = new Import
            {
                ImportDate = DateTime.Now,
                ImportDetails = new List<ImportDetail>()
            };

            foreach (var item in vm.Items)
            {
                import.ImportDetails.Add(new ImportDetail
                {
                    DeviceId = item.DeviceId,
                    Quantity = item.Quantity,
                    Price = item.Price
                });

                var device = _context.Devices.Find(item.DeviceId);

                if (device != null)
                {
                    device.Quantity += item.Quantity; 
                }
            }

            _context.Imports.Add(import);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}