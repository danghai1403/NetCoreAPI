using Microsoft.AspNetCore.Mvc;
using BaiThucHanhSo4.Models.Entities;
namespace BaiThucHanhSo4.Controllers
{

    public class StudentController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
[HttpPost]
        public IActionResult Index(Student std)
        {
            ViewBag.Thongbao = "Xin chào : " + std.FullName + " - Mã sinh viên: " + std.StudentCode;
            return View();
        }
    }
}
