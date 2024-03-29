using Dapper;
using Domain.Models;
using Infrastrcture.DataContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Infrastrcture.Services
{
    public class StudentCourseService : IStudentCourseService
    {
        private readonly DapperContext _context;
        public StudentCourseService()
        {
            _context = new DapperContext();
        }
        public string Add(StudentCourse studentCourse)
        {
            var sql = $"insert into studentCourse(studentId,courseId)values({studentCourse.StudentId},{studentCourse.CourseId})";
            var result = _context.Connection().Execute(sql);
            if (result > 0)
            {
                return "Succesfully added to db";
            }
            return "Error in adding to db";
        }

        public bool Delete(int id)
        {
            var sql = $"Delete from studentCourse where id={@id}"; 
            var result= _context.Connection().Execute(sql);
            if (result > 0)
            {
                return true;
            }
            return false;
        }

        public List<StudentCourse> GetAll()
        {
            var sql = $"Select * from studentCourse";
            var result=_context.Connection().Query<StudentCourse>(sql).ToList();
            return result;

        }

        public string Update(StudentCourse studentCourse)
        {
            var sql = $"update studentCourse set studentId={studentCourse.StudentId} ,courseId={studentCourse.CourseId} " +
                $"where id={studentCourse.Id}";
            var result = _context.Connection().Execute(sql); 
            if (result > 0)
            {
                return "Succesfully updated";
            }
            return "Error in updating";
        } 
        
    }
}
