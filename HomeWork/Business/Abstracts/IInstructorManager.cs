using HomeWork.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork.Business.Abstracts
{
    public interface IInstructorManager
    {

        void Add(Instructor instructor);
        void Delete(int instructorId);
        void Update(Instructor instructor);
        List<Instructor> GetListAll();
        Instructor GetById(int id);
        


    }
}
