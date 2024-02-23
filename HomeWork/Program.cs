using HomeWork.Business.Concrets;
using HomeWork.Business.Abstracts;
using HomeWork.DataAccess.Abstracts;
using HomeWork.DataAccess.Concrets;
using HomeWork.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace HomeWork
{

    public class Program
    {
       
        static void Main(string[] args)
        {
            int select;

            do
            {
                Console.WriteLine("\nWelcome to the Kodlama.io");

                Console.WriteLine("\nPlease, enter the number of operation you want to make:\n");

                Console.WriteLine("1) Category Operations");
                Console.WriteLine("2) Instructor Operations");
                Console.WriteLine("3) Course Operations");
                Console.WriteLine("4) Exit\n");


                
                select = Convert.ToInt32(Console.ReadLine());

                switch (select)
                {

                    case 1:
                        CategoryOperation(new CategoryManager(new CategoryDal()));
                        break;
                    case 2:
                        InstructorOperation(new InstructorManager(new InstructorDal()));
                        break;
                    case 3:
                        CourseOperation(new CourseManager(new CourseDal()));
                        break;
                    case 4:
                        Console.WriteLine("Exiting the system...");
                        break;
                    default:
                        Console.WriteLine("Please, enter a valid number.");
                        break;
                }

                if (select != 4)
                {
                    {
                        Console.WriteLine("\nEnter the number of the method you want to continue with.");
                        Console.WriteLine("\n1)Clear the page and return to the main menu.");
                        Console.WriteLine("2)Keep past operations on the screen and return to the main menu.");

                        int a;
                        a = Convert.ToInt32(Console.ReadLine());

                        if (a == 1)
                        {
                            Console.Clear();
                        }
                        else if (a == 2)
                        {

                        }
                        else
                        {
                            Console.WriteLine("\nYou entered an invalid number.You are being redirected to the main menu...");

                        }

                    }
                }

            } while (select != 4);




            Console.ReadLine();

        }
            static void CategoryOperation(CategoryManager categoryManager)
            {


                Console.WriteLine("\nPlease, enter the number you want to make the Category Operations: \n");

                Console.WriteLine("1) List the category.");
                Console.WriteLine("2) Add a new category.");
                Console.WriteLine("3) Update the category.");
                Console.WriteLine("4) Delete the category.");
                Console.WriteLine("5) Get to the category by Category Id number.\n");



                int operation;
                operation = Convert.ToInt32(Console.ReadLine());

                string categoryname;
                int categoryid;



                if (operation == 1)
                {
                    categoryManager.GetListAll();

                }



                else if (operation == 2)
                {

                    Console.WriteLine("\nPlease, enter the Category Id number of the category you want to add:");
                    categoryid = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("\nPlease, enter the category name:");
                    categoryname = Convert.ToString(Console.ReadLine());


                    Console.WriteLine("\nAfter Addition\n");
                    categoryManager.Add(new Category(categoryid, categoryname));
                    categoryManager.GetListAll();

                }

                else if (operation == 3)

                {
                    Console.WriteLine("\nPlease, enter the Category Id Number of the category you want to update:");

                    categoryid = Convert.ToInt32(Console.ReadLine());


                    Console.WriteLine("\nPlease, enter the new category name:");
                    categoryname = Convert.ToString(Console.ReadLine());



                    categoryManager.Update(new Category(categoryid, categoryname));
                    Console.WriteLine("\nAfter Update\n");
                    categoryManager.GetListAll();


                }


                else if (operation == 4)
                {
                    Console.WriteLine("\nPlease, enter the Category Id Number of the category you want to delete:");

                    categoryid = Convert.ToInt32(Console.ReadLine());

                    categoryManager.Delete(categoryid);
                    Console.WriteLine("\nAfter Deletion\n");
                    categoryManager.GetListAll();

                }


                else if (operation == 5)
                {

                    Console.WriteLine("\nPlease, enter the Category Id Number of the category you want to get:");
                    categoryid = Convert.ToInt32(Console.ReadLine());
                    categoryManager.GetById(categoryid);

                }

                else
                {
                    Console.WriteLine("\nPlease, enter a valid number.");
                    CategoryOperation(categoryManager);
                }

            }








            static void InstructorOperation(InstructorManager instructorManager)
            {


                Console.WriteLine("\nPlease, enter the number you want to make the Instructor Operations: \n");

                Console.WriteLine("1) List the instructor.");
                Console.WriteLine("2) Add a new instructor.");
                Console.WriteLine("3) Update the instructor.");
                Console.WriteLine("4) Delete the instructor.");
                Console.WriteLine("5) Get to the instructor by Instructor Id number.\n");


                int operation;
                operation = Convert.ToInt32(Console.ReadLine());

                string instructorfirstname;
                string instructorlastname;
                int instructorid;


              switch (operation)
              {

                case 1:

                    instructorManager.GetListAll();
                    break;

                case 2:

                    Console.WriteLine("\nPlease, enter the Instructor Id number of the instructor you want to add:");
                    instructorid = Convert.ToInt32(Console.ReadLine());


                    Console.WriteLine("\nPlease, enter the instructor first name:");
                    instructorfirstname = Convert.ToString(Console.ReadLine());

                    Console.WriteLine("\nPlease, enter the instructor last name:");
                    instructorlastname = Convert.ToString(Console.ReadLine());


                    Console.WriteLine("\nAfter Addition\n");
                    instructorManager.Add(new Instructor(instructorid, instructorfirstname, instructorlastname));
                    instructorManager.GetListAll();

                    break;



                case 3:

                    Console.WriteLine("\nPlease, enter the Instructor Id Number of the instructor you want to update:");

                    instructorid = Convert.ToInt32(Console.ReadLine());


                    Console.WriteLine("\nPlease, enter the new instructor first name:");
                    instructorfirstname = Convert.ToString(Console.ReadLine());

                    Console.WriteLine("\nPlease, enter the new instructor last name:");
                    instructorlastname = Convert.ToString(Console.ReadLine());


                    instructorManager.Update(new Instructor(instructorid, instructorfirstname, instructorlastname));
                    Console.WriteLine("\nAfter Update\n");
                    instructorManager.GetListAll();

                    break;





                case 4:

                    Console.WriteLine("\nPlease, enter the Instructor Id Number of the instructor you want to delete:");

                    instructorid = Convert.ToInt32(Console.ReadLine());

                    instructorManager.Delete(instructorid);
                    Console.WriteLine("\nAfter Deletion\n");
                    instructorManager.GetListAll();

                    break;



                case 5:


                    Console.WriteLine("\nPlease, enter the Insturctor Id Number of the instructor you want to get:");
                    instructorid = Convert.ToInt32(Console.ReadLine());
                    instructorManager.GetById(instructorid);

                    break;

                default:

                    Console.WriteLine("\nPlease, enter a valid number.");
                    InstructorOperation(instructorManager);
                    break;


              }
            
            }





                static void CourseOperation (CourseManager courseManager)
                {

                    Console.WriteLine("\nPlease, enter the number you want to make the Course Operations: \n");

                    Console.WriteLine("1) List the course.");
                    Console.WriteLine("2) Add a new course.");
                    Console.WriteLine("3) Update the course.");
                    Console.WriteLine("4) Delete the course.");
                    Console.WriteLine("5) Get to the course by Course Id number.\n");


                    int operation;
                    operation = Convert.ToInt32(Console.ReadLine());

                    int courseId;
                    string courseName;
                    string description;
                    int categoryId;
                    int instructorId;
                    string coursePrice;


                switch (operation)
                {

                    case 1:

                        courseManager.GetListAll();
                        break;

                    case 2:

                        Console.WriteLine("\nPlease, enter the Course Id number of the  you want to add:");
                        courseId = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("\nPlease, enter the Category Id number of the  you want to add:");
                        categoryId = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("\nPlease, enter the Instructor Id number of the  you want to add:");
                        instructorId = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("\nPlease, enter the course name:");
                        courseName = Convert.ToString(Console.ReadLine());

                        Console.WriteLine("\nPlease, enter the description:");
                        description = Convert.ToString(Console.ReadLine());

                        Console.WriteLine("\nPlease, enter the course price:");
                        coursePrice = Convert.ToString(Console.ReadLine());

                        Console.WriteLine("\nAfter Addition\n");
                        courseManager.Add(new Course(courseId, courseName, description, categoryId, instructorId, coursePrice));
                        courseManager.GetListAll();

                        break;



                    case 3:

                        Console.WriteLine("\nPlease, enter the Course Id number of the  you want to update:");
                        courseId = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("\nPlease, enter the Category Id number of the  you want to update:");
                        categoryId = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("\nPlease, enter the Instructor Id number of the  you want to update:");
                        instructorId = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("\nPlease, enter the course name:");
                        courseName = Convert.ToString(Console.ReadLine());

                        Console.WriteLine("\nPlease, enter the description:");
                        description = Convert.ToString(Console.ReadLine());

                        Console.WriteLine("\nPlease, enter the course price:");
                        coursePrice = Convert.ToString(Console.ReadLine());

                        Console.WriteLine("\nAfter Update\n");
                        courseManager.Add(new Course(courseId, courseName, description, categoryId, instructorId, coursePrice));
                        courseManager.GetListAll();

                        break;


                    case 4:

                        Console.WriteLine("\nPlease, enter the Course Id Number of the course you want to delete:");

                        courseId = Convert.ToInt32(Console.ReadLine());

                        courseManager.Delete(courseId);
                        Console.WriteLine("\nAfter Deletion\n");
                        courseManager.GetListAll();

                        break;



                    case 5:

                        Console.WriteLine("\nPlease, enter the Course Id Number of the course you want to get:");

                        courseId = Convert.ToInt32(Console.ReadLine());

                        courseManager.Delete(courseId);
                        Console.WriteLine("\nAfter Getting\n");
                        courseManager.GetListAll();

                        break;




                    case 6:

                        Console.WriteLine("\nPlease, enter the Category Id Number of the course you want to get:");

                        categoryId = Convert.ToInt32(Console.ReadLine());

                        courseManager.Delete(categoryId);
                        Console.WriteLine("\nAfter Getting\n");
                        courseManager.GetListAll();

                        break;



                    case 7:

                        Console.WriteLine("\nPlease, enter the Instructor Id Number of the course you want to get:");

                        instructorId = Convert.ToInt32(Console.ReadLine());

                        courseManager.GetByCategory(instructorId);

                        Console.WriteLine("\nAfter Getting\n");
                        courseManager.GetListAll();

                        break;


                    default:

                        Console.WriteLine("\nPlease, enter a valid number.");
                        CourseOperation(courseManager);
                        break;

                }
                    

             }


    }
}
