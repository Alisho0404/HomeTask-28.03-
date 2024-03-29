using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Models;

namespace Infrastrcture.Services
{
    public interface IStudentService
    {
        List<Student> GetStudent(); 
        string AddStudent(Student student);
        string UpdateStudent(Student student);
        bool DeleteStudent(int id);
    }
}
