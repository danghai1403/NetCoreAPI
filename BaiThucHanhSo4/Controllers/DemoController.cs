using Microsoft.AspNetCore.Mvc;

namespace BAITHUCHANHSO4.Controllers
{
    public class DemoController : Controller
    {
        public IActionResult Index()
        {
        
            ViewBag.FullName = "Xin chào Nguyễn Đăng Hải";
            return View();
        }
       
    }
}