using Interview_Practice.Models;
using Microsoft.AspNetCore.Mvc;


namespace Interview_Practice.Controllers
{
    public class StudentController : Controller
    {
        private myContext _mycontext;
        public StudentController(myContext mycontext)
        {
            _mycontext = mycontext;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(Student student)
        {
            _mycontext.tbl_student.Add(student);
            _mycontext.SaveChanges();
            return View();
        }
    }
}
