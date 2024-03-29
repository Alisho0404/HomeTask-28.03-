using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Models;

namespace Infrastrcture.Services
{
    public interface IMentorCourseService
    {
        List<MentorCourse> GetAll();  
        string Add(MentorCourse mentorCourse);
        string Update(MentorCourse mentorCourse);
        bool Delete(int id);
    }
}
