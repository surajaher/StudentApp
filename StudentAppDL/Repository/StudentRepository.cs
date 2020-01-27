using StudentAppBL.Models;
using StudentAppBL.DomainService;
using StudentAppBL.IRepository;
using System;
using System.Collections.Generic;
using System.Text;

namespace StudentAppDL.Repository
{
   public class StudentRepository : IStudentRepository
    {
        private readonly AppDbContext _context;

        public StudentRepository(AppDbContext context)
        {
         _context = context;
        }
        public StudentsModel Add(StudentsModel employee)
        {
        _context.Students.Add(employee);
       _context.SaveChanges();
            return employee;
        }

        public StudentsModel Delete(int Id)
        {
            StudentsModel employee = _context.Students.Find(Id);
            if (employee != null)
            {
               _context.Students.Remove(employee);
               _context.SaveChanges();
            }
            return employee;
        }

        public IEnumerable<StudentsModel> GetAllStudents()
        {
            return _context.Students;
        }

        public StudentsModel GetStudent(int Id)
        {
            return _context.Students.Find(Id);
        }

        public StudentsModel Update(StudentsModel employeeChanges)
        {
            var employee = _context.Students.Attach(employeeChanges);
            employee.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();
            return employeeChanges;
        }
    }
}