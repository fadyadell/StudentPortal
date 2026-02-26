using StudentPortal.Models;
using System.Collections.Generic;

namespace StudentPortal.Interfaces
{
    public interface ICourseService
    {
        List<Course> GetAll();
        Course GetById(int id);
        void Add(Course course);
    }
}
