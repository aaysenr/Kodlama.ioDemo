using HomeWork.Entities;
using HomeWork.DataAccess.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork.DataAccess.Concrets
{
    public class CourseDal : ICourseDal

    {
 
        private readonly List <Course> courses;

        public CourseDal()
        
        {

            courses = new List<Course>

            {
                new Course (1, "C# + Angular", "Yazılım Geliştirici Yetiştirme Kampı (C# + ANGULAR)", 1, 1, "Ücretsiz" ),
                new Course (2, "Java", "(2022) Yazılım Geliştirici Yetiştirme Kampı - JAVA ", 1, 1, "Ücretsiz"),
                new Course (3, "Python & Selenium", "(2023) Yazılım Geliştirici Yetiştirme Kampı - Python & Selenium", 1, 2, "Ücretsiz"),
                new Course (4, "JavaScript", "Yazılım Geliştirici Yetiştirici Kampı (JavaScript)", 1, 1, "Ücretsiz"),
                new Course(5, "Java + React", "Yazılım Geliştirici Yetiştirici Kampı (JAVA + REACT)", 1, 1, "Ücretsiz"),
                new Course(6, ".Net", "Senior Yazılım Geliştirici Yetiştirme Kampı (.NET)", 1, 1, "Ücretsiz"),
                new Course(7, "C#", "2024 Yazılım Geliştirici Yetiştirme Kampı (C#)", 1, 1, "Ücretsiz"),
                new Course(8, "Temel", "Programlamaya Giriş İçin Temel Kurs", 1, 1, "Ücretsiz")
            };

        }


        public void Add (Course course)

        { 
            courses.Add(course);

            Console.WriteLine("\nThe cours called " + " ' " + course.CourseName + " ' " + " was added successfully.");

        }


        public void Delete(int courseId)
        {
           
            var result = courses.FirstOrDefault(c => c.CourseId == courseId);


            if (result != null)
            {
                courses.Remove(result);

                Console.WriteLine("\nThe cours called ' " + result.CourseName + " ' was deleted successfully.");

            }

            else
            {
                Console.WriteLine($"\nNo course with the entered ID ( {courseId} ) was found.");
            }
        }



        public void Update(Course course)
        {

            var result = courses.FirstOrDefault(c => c.CourseId == course.CourseId);

            if (result != null)
            {
                result.CourseName = course.CourseName;
                result.Description = course.Description;
                result.CategoryId = course.CategoryId;
                result.InstructorId = course.InstructorId;
                result.CoursePrice = course.CoursePrice;

                Console.WriteLine("\nThe cours called ' " + result.CourseName + " '  was updated successfully");

            }

            else
            {
                Console.WriteLine($"\nNo category with the entered ID ( {course.CourseId} ) was found.");

            }

        }




        public Course GetById (int id)
        {

            var result = courses.FirstOrDefault(c => c.CourseId == id);

            if (result != null)
            {
                Console.WriteLine("\nThe id ' " + result.CourseId + " ' course is" + " ' " + result.CourseName + " ' ") ;

                return result;
            }

             else

            {
                Console.WriteLine($"\nNo course with the entered ID ( {id} ) was found.");

                return null ;

            }

          
        }




        public List <Course> GetListAll()

        {
            
            Console.WriteLine("\nAll courses are listed: ");


            foreach (Course course in courses)
                
            Console.WriteLine($"\nCourseId: {course.CourseId} , CourseName: {course.CourseName} ");

            return courses;
       
        }



        public List<Course> GetByCategory(int categoryId)
        {
            var result = courses.Where(c => c.CategoryId == categoryId).ToList();

            

            if (result.Count == 0)
            {
                
                Console.WriteLine($"\nNo course with the entered ID ( {categoryId} ) was found.");

                return null;

            }

            Console.WriteLine("All courses with category ID number ' " + categoryId + " ' were listed: ");

                foreach (var item in result)
                {
                    Console.WriteLine($"\nCourseId: {item.CourseId} , CourseName: {item.CourseName} ");
                }

                return result;

        }


        public List<Course> GetByInstructor(int instructorId)
        {
            var result = courses.Where(c => c.InstructorId == instructorId).ToList();


            if (result.Count == 0)
            {
    
                Console.WriteLine($"\nNo course with the entered ID ( {instructorId} ) was found.");

                return null;

            }

            Console.WriteLine("\nAll courses with instructor ID number ' " + instructorId + " ' were listed: ");

                foreach (var item in result)
                {
                    Console.WriteLine($"\nCourseId: {item.CourseId} , CourseName: {item.CourseName} ");
                }

                return result;
                 
            
        }

    }

}