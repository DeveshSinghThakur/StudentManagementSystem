using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StudentManagement.UI.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult ShowAllStudents()
        {
            return View();
        }
    }
}