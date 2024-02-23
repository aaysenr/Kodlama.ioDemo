using HomeWork.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork.Business.Abstracts
{
    public interface ICategoryManager
    {
        void Add(Category category);
        void Delete(int categoryId);
        void Update(Category category);
        List<Category> GetListAll();
        Category GetById(int id);



    }
}
