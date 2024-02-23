using HomeWork.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork.Business.Abstracts
{
    public interface ICourseManager
    {

        void Add(Course course);

        void Delete(int courseId);

        void Update( Course course);

        Course GetById(int id);

        List<Course> GetListAll();

        List<Course> GetByCategory(int categoryId);

        List<Course> GetByInstructor(int instructorId);


    }
        
}
