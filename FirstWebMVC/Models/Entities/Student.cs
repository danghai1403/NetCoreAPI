using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using FirstWebMVC.Models.Entities;

namespace FirstWebMVC.Models.Entities
{
    public class Student
    {
        public int Id { get; set; }
        public string FullName { get; set; }

        public string StudentCode { get; set; }

        
        public int FacultyId { get; set; }

        
        public Faculty Faculty { get; set; }
        public int Age { get; set; }
    }
}