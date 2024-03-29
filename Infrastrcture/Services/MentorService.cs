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
    public class MentorService : IMentorService
    {
        private readonly DapperContext _context;
        public MentorService()
        {
            _context = new DapperContext();
        }
        public string AddMentor(Mentor mentor)
        {
            var sql = $"insert into mentors(firstname,lastname,position)" +
                $"values('{mentor.FirstName}','{mentor.LastName}','{mentor.Position}')";
            var result = _context.Connection().Execute(sql);
            if (result>0)
            {
                return "Mentor added to DB";
            }
            return "Error in adding mentor to DB";
        }

        public bool DeleteMentor(int id)
        {
            var sql = $"Delete from mentors where id={@id}";
            var result = _context.Connection().Execute(sql);
            if(result>0) 
            { 
                return true; 
            }
            return false;
        }

        public List<Mentor> GetAllMentors()
        {
            var sql = "Select * from mentors";
            var result= _context.Connection().Query<Mentor>(sql).ToList();
            return result;
        }

        public string UpdateMentor(Mentor mentor)
        {
            var sql = $"update mentors set " +
                $"firstname='{mentor.FirstName}',lastName='{mentor.LastName}',position='{mentor.Position}'where id={mentor.Id}";
            var result=_context.Connection().Execute(sql);
            if (result>0)
            {
                return "Mentor updated";
            }
            return "Something went wrong in updating mentor";
        }
    }
}
