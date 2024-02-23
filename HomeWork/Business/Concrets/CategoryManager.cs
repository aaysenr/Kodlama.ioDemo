using HomeWork.DataAccess.Abstracts;
using HomeWork.Entities;
using HomeWork.Business.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork.Business.Concrets
{
    public class CategoryManager: ICategoryManager
    {
        private ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public void Add(Category category)
        {
            _categoryDal.Add(category);
            
        }

        public void Delete(int categoryId)
        {
            _categoryDal.Delete(categoryId);
            
        }

        public void Update(Category category)
        {
            _categoryDal.Update (category);
            
        }

        public List<Category> GetListAll()
        {
            return _categoryDal.GetListAll();
        }

        public Category GetById(int id)
        {
            return _categoryDal.GetById(id);
        }

    

    }
}
