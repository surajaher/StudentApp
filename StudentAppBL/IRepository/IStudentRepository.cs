using StudentAppBL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace StudentAppBL.IRepository
{
   public interface IStudentRepository
    {
        StudentsModel GetStudent(int Id);
        IEnumerable<StudentsModel> GetAllStudents();
        StudentsModel Add(StudentsModel Student);
        StudentsModel Update(StudentsModel StudentsChanges);
        StudentsModel Delete(int Id);
    }
}
