using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class MentorCourse
    {
        public int Id { get; set; }
        public int MentorId { get; set; }
        public int CourseId { get; set; }
    }
}
