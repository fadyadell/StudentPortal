using StudentPortal.Models;
using System.Collections.Generic;

namespace StudentPortal.Interfaces
{
    public interface IStudentService
    {
        List<Student> GetAll();
        Student GetById(int id);
        void Add(Student student);
    }
}
