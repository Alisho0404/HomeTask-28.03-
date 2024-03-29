using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Models;

namespace Infrastrcture.Services
{
    public interface IMentorService
    { 
        List<Mentor> GetAllMentors(); 
        string AddMentor(Mentor mentor);
        string UpdateMentor(Mentor mentor);
        bool DeleteMentor(int id);

    }
}
