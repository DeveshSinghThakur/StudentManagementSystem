using StudentManagementDataLayer.Providers.Student;
using StudentManagment.API.Utility;
using StudentManagment.API.ViewModels.Students;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using System.Web.Http.Cors;

namespace StudentManagment.API.Controllers
{
    [EnableCors(origins:"*",headers:"*",methods:"*")]
    public class StudentController : ApiController
    {
        public IEnumerable<SelectStudentViewModel> Get()
        {
           List<SelectStudentViewModel> studentsViewModel = new List<SelectStudentViewModel>();
            StudentProvider Studprovider = new StudentProvider(GenericMethodHandler.GetConnectionString());
           var students=   Studprovider.GetStudents();
            foreach (var student in students)
            {
                SelectStudentViewModel studentviewModel = new SelectStudentViewModel();

                studentviewModel.Id = student.Id;
                studentviewModel.Name = student.Name;
                studentviewModel.EmailId = student.EmailId;
                studentsViewModel.Add(studentviewModel);
            }
            return studentsViewModel;
           
        }
    }
}
