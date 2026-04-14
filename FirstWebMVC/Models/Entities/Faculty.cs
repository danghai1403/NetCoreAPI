using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using FirstWebMVC.Models.Entities;

namespace FirstWebMVC.Models.Entities
{
    public class Faculty
    {
        [Key]
        public int FacultyID { get; set; }

        [Required]
        public string FacultyName { get; set; }

        // Quan hệ 1-n: 1 khoa có nhiều sinh viên
        public ICollection<Student> Students { get; set; }
    }
}