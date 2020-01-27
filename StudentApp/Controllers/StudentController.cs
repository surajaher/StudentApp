//using Microsoft.AspNetCore.Mvc;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;
//using StudentAppBL.Models;
//using StudentApp.DomainServices;
//using Microsoft.AspNetCore.Http;
//using Microsoft.AspNetCore.Diagnostics;

//namespace StudentApp.Controllers
//{
//    public class StudentController : Controller
//    {
//         public StudentController()
//        {
//            _studentDomainService = studentDomainService;
//        }

//        public ViewResult AllStudents()
//        {
//             throw new Exception("from AllStudents");
//            List<StudentsModel> studentsData = new List<StudentsModel>();
//            studentsData = _studentDomainService.AllStudents();
//            return View(studentsData);
//        }
//        public ActionResult DeleteStudent(string id)
//        {
//           var isDeleted = _studentDomainService.DeleteStudent(id);
//             return RedirectToAction("AllStudents", "Student");
//        }
//        [HttpGet]
//        public ViewResult CreateStudent()
//        {
//            return View();
//        }

//        [HttpPost]
//        public ActionResult CreateStudent(StudentsModel studentsData)
//        {
//        //    StudentsModel studentsData = new StudentsModel();
//        //    studentsData.id = formData["id"];
//        //    studentsData.name = formData["name"];
//        //    studentsData.address = formData["address"];
//            var isAdded =_studentDomainService.CreateStudent(studentsData);
//            return RedirectToAction("AllStudents", "Student");
//        }

//        [HttpGet]
//        public ActionResult EditStudent(string id)
//        {
//            StudentsModel studentsData = new StudentsModel();
//         //   studentsData = _studentDomainService.AllStudents().Single(x =>x.id ==id);

//            return View(studentsData);
//        }

//        [HttpPost]
//        public ActionResult EditStudent(StudentsModel studentsData)
//        {
//            var isAdded = _studentDomainService.EditStudent(studentsData);
//            return RedirectToAction("AllStudents", "Student");
//        }

//    }
//}
