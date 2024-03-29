using Dapper;
using Domain.Models;
using Infrastrcture.DataContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Infrastrcture.Services
{
    public class CourseService : ICourseService
    {
        private readonly DapperContext _context;
        public CourseService()
        {
            _context = new DapperContext();
        }
        public string AddCourse(Course course)
        {
            var sql = $"insert into courses(courseName)values('{course.CourseName}')";
            var insert = _context.Connection().Execute(sql);
            if (insert > 0)
            {
                return "Course added to DB";
            }
            return "Error in adding course to DB";
        }

        public bool DeleteCourse(int id)
        {
            var sql = $"Delete from courses where id={@id}";
            var delete = _context.Connection().Execute(sql);
            if (delete > 0)
            {
                return true;
            }
            return false;
        }

        public List<Course> GetAllCourse()
        {
            var sql = "Select * from courses";
            var result = _context.Connection().Query<Course>(sql).ToList();
            return result;
        }

        public string UpdateCourse(Course course)
        {
            var sql = $"update courses set courseName='{course.CourseName}' where id={course.Id}";
            var update = _context.Connection().Execute(sql);
            if (update > 0)
            {
                return "Succesfully updated";
            }
            return "Error in updating";
        }
    }
}
