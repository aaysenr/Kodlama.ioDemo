using HomeWork.Entities;
using HomeWork.DataAccess.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork.DataAccess.Concrets
{
    public class CategoryDal: ICategoryDal

    {
        private readonly List<Category> categories;

  

        public CategoryDal()
        {
 
            categories = new List<Category>

            {
                new Category (1, "Programlama")
             };


        }

        public void Add(Category category)
        {
            

            categories.Add(category);

            Console.WriteLine("\nThe category called ' " + category.CategoryName + " '  was added successfully.");

        }




        public void Delete(int categoryId)
        {   
            var result = categories.FirstOrDefault(c => c.CategoryId == categoryId);

            if (result != null)
            {
                categories.Remove(result);

                Console.WriteLine("\nThe category called ' " + result.CategoryName + " ' with CategoryId Number is ' " + result.CategoryId + " ' was deleted successfully.");

            }

            else
            {
                Console.WriteLine($"\nNo category with the entered ID ( {categoryId} ) was found.");

            }
        }




        public void Update(Category category)
        {
            var result = categories.FirstOrDefault(c => c.CategoryId == category.CategoryId);

            if (result != null)
            {
                result.CategoryName = category.CategoryName;

                result.CategoryId = category.CategoryId;

                Console.WriteLine("\nThe name of the category with CategoryId Number is '" + result.CategoryId + " ' was successfully updated to " + result.CategoryName );

            }

            else
            {
                Console.WriteLine($"\nNo category with the entered ID ( {category.CategoryId} ) was found.");
            }

        }


        public Category GetById(int id)
        {
            var result = categories.SingleOrDefault(c => c.CategoryId == id);

            if (result != null)
            {
                Console.WriteLine("\nThe id ' " + result.CategoryId + " ' category is" + " ' " + result.CategoryName + " ' ");

                return result;
            }

            else

            {
                Console.WriteLine($"\nNo category with the entered ID ( {id} ) was found.");

                return null;

            }


        }

        public List<Category> GetListAll()

        {
            Console.WriteLine("\nAll categories are listed: ");

            foreach (Category category in categories)

                Console.WriteLine($"\nCategoryId: {category.CategoryId} , CategoryName: {category.CategoryName} ");

            return categories;

            
        }


    }
}


