namespace FirstWebMVC.Models.ViewModels
{
    public class StudentFacultyViewModel
    {
        public int Id { get; set; }
        public string StudentCode { get; set; }
        public string FullName { get; set; }

        public int FacultyId { get; set; }   // khóa ngoại
        public string FacultyName { get; set; } // hiển thị
    }
}