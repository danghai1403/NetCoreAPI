using Microsoft.AspNetCore.Mvc;
using FirstWebMVC.Data;
using FirstWebMVC.Models.Entities;;
using System.Linq;

namespace FirstWebMVC.Controllers
{
    public class StudentController : Controller
    {
        private readonly ApplicationDbContext _context;

        public StudentController(ApplicationDbContext context)
        {
            _context = context;
        }

        // Hiển thị danh sách sinh viên
        public IActionResult Index()
        {
            var students = _context.Students.ToList();
            return View(students);
        }

        // Form thêm sinh viên
        public IActionResult Create()
        {
            return View();
        }

        // Lưu dữ liệu
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Student student)
        {
            if (ModelState.IsValid)
            {
                _context.Students.Add(student);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(student);
        }

        // Xem chi tiết sinh viên
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return View("NotFound");
            }

            var student = _context.Students.FirstOrDefault(s => s.Id == id);

            if (student == null)
            {
                return View("NotFound");
            }

            return View(student);
        }
    }
}