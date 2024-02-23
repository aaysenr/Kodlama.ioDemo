using HomeWork.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork.DataAccess.Abstracts
{
    public interface IInstructorDal
    {
        void Add(Instructor instructor);

        void Delete(int instructorId);

        void Update(Instructor instructor);

        Instructor GetById(int id);

        List<Instructor> GetListAll();

    }
}
