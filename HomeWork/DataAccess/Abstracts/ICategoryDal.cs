using HomeWork.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork.DataAccess.Abstracts
{

    public interface ICategoryDal
    {
        void Add(Category category);

        void Delete(int categoryId);

        void Update(Category category);

        Category GetById(int id);

        List<Category> GetListAll();

    }
}
