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
    public class MentorCourseService : IMentorCourseService
    {
        private readonly DapperContext _context;
        public MentorCourseService()
        {
            _context = new DapperContext();
        }
        public string Add(MentorCourse mentorCourse)
        {
            var sql = $"insert into mentorCourse(mentorId,courseId)values({mentorCourse.MentorId},{mentorCourse.CourseId})";
            var result = _context.Connection().Execute(sql);
            if (result>0)
            {
                return "Succesfully added to DB";
            }
            return "Error in adding to DB";
        }

        public bool Delete(int id)
        {
            var sql = $"Delete from mentorCourse where id={@id}";
            var result= _context.Connection().Execute(sql);
            if (result>0)
            {
                return true;
            }
            return false;
        }

        public List<MentorCourse> GetAll()
        {
            var sql = $"Select * from mentorCourse";
            var result=_context.Connection().Query<MentorCourse>(sql).ToList();
            return result;

        }

        public string Update(MentorCourse mentorCourse)
        {
            var sql = $"update table studentCourse " +
                $"set mentorId={mentorCourse.MentorId} ,courseId={mentorCourse.CourseId}  where id={mentorCourse.Id}";
            var result=_context.Connection().Execute(sql); 
            if (result>0) 
            {
                return "Succesfully updated";
            }
            return "Error in updating";
        }
    }
}
