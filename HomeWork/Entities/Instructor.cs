using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork.Entities
{
    public class Instructor
    {
        
        public Instructor (int instructorId, string instructorFirstName, string instructorLastName)
        {

            InstructorId = instructorId;
            InstructorFirstName = instructorFirstName;
            InstructorLastName = instructorLastName;
          
        }
        public int InstructorId { get; set; }
        public string InstructorFirstName { get; set; }
        public string InstructorLastName { get; set; }
    }
}
