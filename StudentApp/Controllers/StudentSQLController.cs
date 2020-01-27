using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using StudentAppBL.Models;
using StudentAppBL.DomainService;
using StudentAppBL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentApp.Controllers
{
    [Authorize]
    public class StudentSQLController: Controller
    {
      //  private readonly IStudentRepository _studentRepository;
        private readonly IStudentDomainService _studentDomainService;

        public StudentSQLController(IStudentDomainService studentDomainService)
        {
            _studentDomainService = studentDomainService;
        }

        [AllowAnonymous]
        public ActionResult GetAllStudents()
        {

            var model = _studentDomainService.GetAllStudents();
            return View(model);
        }

        public ActionResult DeleteStudent(int id)
        {
            var model = _studentDomainService.Delete(id);
            return RedirectToAction("GetAllStudents");
        }

        [HttpGet]
        public ViewResult CreateStudent()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateStudent(StudentsModel studentsData)
        {
            var model = _studentDomainService.Add(studentsData);
            return RedirectToAction("GetAllStudents");
        }

        public ActionResult EditStudent(int id)
        {
            StudentsModel stud = _studentDomainService.GetStudent(id);
            return View(stud);
        }

        [HttpPost]
        public ActionResult EditStudent(StudentsModel stud)
        {
            var model = _studentDomainService.Update(stud);
            return RedirectToAction("GetAllStudents");
        }
    }
}
