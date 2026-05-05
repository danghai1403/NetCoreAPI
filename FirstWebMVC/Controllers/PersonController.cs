using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using FirstWebMVC.Data;
using FirstWebMVC.Models.Entities;
using FirstWebMVC.Models.Process;
using FirstWebMVC.Models;

namespace FirstWebMVC.Controllers
{
    public class PersionController : Controller
    {
        private readonly ApplicationDbContext _context;
        private ExcelProcess _excelProcess = new ExcelProcess();

        public PersionController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Upload()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Upload(IFormFile file)
        {
            if (file != null)
            {
                string fileExtension = Path.GetExtension(file.FileName);

                if (fileExtension != ".xlsx" && fileExtension != ".xls")
                {
                    ModelState.AddModelError("File", "Please upload an Excel file.");
                }
                else
                {
                    // rename file when upload to server
                    var fileName = DateTime.Now.ToString("yyyyMMddHHmmss") + fileExtension;
                    var filePath = Path.Combine(Directory.GetCurrentDirectory(), "Upload", "Excels", fileName);
                    var fileLocation = new FileInfo(filePath).ToString();

                    using (var stream = new FileStream(fileLocation, FileMode.Create, FileAccess.Write))
                    {
                        // save file to server
                        await file.CopyToAsync(stream);
                    }

                    // read data from file and save to database
                    var dt = _excelProcess.ExcelToDataTable(fileLocation);

                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        var ps = new Person();

                        ps.PersonID = dt.Rows[i][0].ToString();
                        ps.FullName = dt.Rows[i][1].ToString();
                        ps.Address = dt.Rows[i][2].ToString();

                        _context.Add(ps);
                    }

                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
            }

            return View();
        }
    }
}