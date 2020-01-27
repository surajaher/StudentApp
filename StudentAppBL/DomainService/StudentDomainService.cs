using StudentAppBL.Models;
using StudentAppBL.IRepository;
using System;
using System.Collections.Generic;
using System.Text;

namespace StudentAppBL.DomainService
{
    public class StudentDomainService : IStudentDomainService
    {
        private readonly IStudentRepository _studentRepository;
        public StudentDomainService(IStudentRepository studentRepository) => _studentRepository = studentRepository;

        public StudentsModel Add(StudentsModel Student)
        {
            return _studentRepository.Add(Student);
        }

        public StudentsModel Delete(int Id)
        {
            return _studentRepository.Delete(Id);
        }

        public IEnumerable<StudentsModel> GetAllStudents()
        {
          return _studentRepository.GetAllStudents();
        }

        public StudentsModel GetStudent(int Id)
        {
            return _studentRepository.GetStudent(Id);
        }

        public StudentsModel Update(StudentsModel StudentsChanges)
        {
            return _studentRepository.Update(StudentsChanges);
        }


    }
}
