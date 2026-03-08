using StudentPortal.Models;
using StudentPortal.Interfaces;
using StudentPortal.Data;
using System.Collections.Generic;
using System.Linq;

namespace StudentPortal.Services
{
    public class StudentService : IStudentService
    {
        private readonly ApplicationDbContext _context;

        public StudentService(ApplicationDbContext context)
        {
            _context = context;
        }

        public List<Student> GetAll()
        {
            return _context.Students.ToList();
        }

        public Student GetById(int id)
        {
            return _context.Students.FirstOrDefault(s => s.Id == id);
        }

        public void Add(Student student)
        {
            _context.Students.Add(student);
            _context.SaveChanges();
        }
    }
}
