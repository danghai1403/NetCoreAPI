using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using BaiThucHanhSo3.Models;


namespace BaiThucHanhSo3.Controllers
{
    public class DemoController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Message = "Hello Nguyễn Đăng Hải - MSV: 2121051554";
            return View();
        }
    }
}
