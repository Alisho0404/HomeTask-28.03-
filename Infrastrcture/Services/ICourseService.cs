using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Models;

namespace Infrastrcture.Services
{
    public interface ICourseService
    {
        List<Course> GetAllCourse(); 
        string AddCourse(Course course);
        string UpdateCourse(Course course);
        bool DeleteCourse(int id);
    }
}
