using StudentPortal.Models;
using StudentPortal.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace StudentPortal.Services
{
    public class StudentService : IStudentService
    {
        private static List<Student> students = new List<Student>();

        public List<Student> GetAll()
        {
            return students;
        }

        public Student GetById(int id)
        {
            return students.FirstOrDefault(s => s.Id == id);
        }

        public void Add(Student student)
        {
            student.Id = students.Count + 1;
            students.Add(student);
        }
    }
}
