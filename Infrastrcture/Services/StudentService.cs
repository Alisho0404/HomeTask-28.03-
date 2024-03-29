using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using Infrastrcture.DataContext;
using Dapper;

namespace Infrastrcture.Services
{
    public class StudentService : IStudentService
    {
        private readonly DapperContext _context;
        public StudentService()
        {
            _context = new DapperContext();
        }

        public string AddStudent(Student student)
        {
            var sql = $"insert into students(firstName,lastName,phone)" +
                $"values('{student.FirstName}','{student.LastName}','{student.Phone}')";
            var result = _context.Connection().Execute(sql);
            if (result>0)
            {
                return "Student added to DB";
            }
            return "Error in adding to DB";
        }

        public bool DeleteStudent(int id)
        {
            var sql = $"Delete from students where id={@id}"; 
            var result= _context.Connection().Execute(sql);
            if (result>0)
            {
                return true;
            }
            return false;
        }

        public List<Student> GetStudent()
        {
            var sql = $"Select * from students";
            var result=_context.Connection().Query<Student>(sql).ToList();
            return result;

        }

        public string UpdateStudent(Student student)
        {
            var sql = $"update students(firstName,lastName,phone)" +
                $"values('{student.FirstName}','{student.LastName}','{student.Phone}')where id={student.Id}"; 
            var result=_context.Connection().Execute(sql);
            if (result>0)
            {
                return "Student succesfully updated";
            }
            return "Error in updating student";
        }
    }
}
