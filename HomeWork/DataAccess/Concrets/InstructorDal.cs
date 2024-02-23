using HomeWork.Entities;
using HomeWork.DataAccess.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork.DataAccess.Concrets
{
    public class InstructorDal : IInstructorDal
    {
     
        private readonly List<Instructor> instructors;
        
        public InstructorDal()
        {           
            instructors = new List<Instructor>

            {

            new Instructor(1,"Engin","Demiroğ"),
            new Instructor(2,"Halit Enes","Kalaycı")

            };
        }

        public void Add(Instructor instructor)
        
        {
            instructors.Add(instructor);
            
            Console.WriteLine("\nThe instructor called ' " + instructor.InstructorFirstName + " " + instructor.InstructorLastName + " ' was added successfully.");

        }



        public void Delete(int instructorId)
        {
            
            var result = instructors.FirstOrDefault(i => i.InstructorId == instructorId);

           
            if (result != null)
            {
                instructors.Remove(result);
             
                Console.WriteLine("\nThe instructor called ' " + result.InstructorFirstName + " " + result.InstructorLastName + " ' was deleted successfully.");
            }

            else
            {
                Console.WriteLine($"\nNo instructor with the entered ID ( {instructorId} ) was found.");    

            }
        }



        public void Update(Instructor instructor)
        {
           
            var result = instructors.FirstOrDefault(i => i.InstructorId == instructor.InstructorId);


            if (result != null)
            {
                result.InstructorId = instructor.InstructorId;
                result.InstructorFirstName = instructor.InstructorFirstName;
                result.InstructorLastName = instructor.InstructorLastName;
               

                Console.WriteLine("\nThe instructor called ' " + result.InstructorFirstName + " " + result.InstructorLastName + " ' was updated successfully");         
            }

            else
            {
                Console.WriteLine($"\nNo instructor with the entered ID ( {instructor.InstructorId} ) was found.");
            }

        }




        public Instructor GetById(int id)
        {
 
            var result = instructors.FirstOrDefault(i => i.InstructorId == id);


            if (result != null)
            {
                Console.WriteLine("\nThe id ' " + result.InstructorId + " ' instructor is ' " + result.InstructorFirstName+ " " + result.InstructorLastName + " ' ");

                return result;
            }

            else

            {
                Console.WriteLine($"\nNo instructor with the entered ID ( {id} ) was found.");

                return null;

            }


        }


        public List <Instructor> GetListAll()

        {
           

            Console.WriteLine("\nAll instructors are listed: ");


            foreach (Instructor instructor in instructors)

                   Console.WriteLine($"\nInstructorId: {instructor.InstructorId} , InstructorName: {instructor.InstructorFirstName}  {instructor.InstructorLastName} ");

            return instructors;

           

        }


    }
}
