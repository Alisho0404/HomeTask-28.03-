using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastrcture.Services
{
    public interface IStudentCourseService
    {
        List<StudentCourse> GetAll();
        string Add(StudentCourse studentCourse);
        string Update(StudentCourse studentCourse);
        bool Delete(int id);
    }
}
