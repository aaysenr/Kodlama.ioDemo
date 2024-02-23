using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork.Entities
{
    public class Course

    {
        public Course(int courseId, string courseName, string description, int categoryId, int ınstructorId, string coursePrice)
        {
         
            CourseId = courseId;
            CourseName = courseName;
            Description = description;
            CategoryId = categoryId;
            InstructorId = ınstructorId;
            CoursePrice = coursePrice;
          
        }

        public int CourseId { get; set; }
        public string CourseName { get; set; }
        public string Description { get; set; }
        public int CategoryId { get; set; }
        public int InstructorId { get; set; }
        public string CoursePrice { get; set; }
    }
}
