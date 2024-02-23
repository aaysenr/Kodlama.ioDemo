using HomeWork.DataAccess.Abstracts;
using HomeWork.Entities;
using HomeWork.Business.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection.Emit;
using System.Reflection.Metadata;
using System.Reflection;
using System.Numerics;

namespace HomeWork.Business.Concrets
{ 
    public class CourseManager: ICourseManager
    {
     private readonly ICourseDal _courseDal;
        public CourseManager(ICourseDal courseDal)
        {   
            _courseDal = courseDal;
         
        }

        public void Add(Course course)
        {
            _courseDal.Add(course);
            
        }

        public void Delete(int courseId)
        {
            _courseDal.Delete(courseId);            
        }

        public void Update(Course course)
        {
            _courseDal.Update(course);
        }

        public Course GetById(int id)
        {
            return _courseDal.GetById(id);
        }

        public List<Course> GetListAll()
        {
            
            return _courseDal.GetListAll();
        }

        public List<Course> GetByCategory(int categoryId)
        {
            return _courseDal.GetByCategory(categoryId);
        }

        public List<Course> GetByInstructor(int instructorId)
        {
            return _courseDal.GetByInstructor(instructorId);
        }


    }
}
