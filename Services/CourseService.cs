using StudentPortal.Models;
using StudentPortal.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace StudentPortal.Services
{
    public class CourseService : ICourseService
    {
        private static List<Course> courses = new List<Course>();

        public List<Course> GetAll()
        {
            return courses;
        }

        public Course GetById(int id)
        {
            return courses.FirstOrDefault(c => c.Id == id);
        }

        public void Add(Course course)
        {
            course.Id = courses.Count + 1;
            courses.Add(course);
        }
    }
}
