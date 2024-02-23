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
    public class InstructorManager : IInstructorManager
    {
        private IInstructorDal _instructorDal;

        public InstructorManager(IInstructorDal instructorDal)
        {
            _instructorDal = instructorDal;
        }

        public void Add(Instructor instructor)
        {
            _instructorDal.Add(instructor);
            
        }

        public void Delete(int instructorId)
        {
            _instructorDal.Delete(instructorId);
            
        }

        public void Update(Instructor instructor)
        {
            _instructorDal.Update(instructor);
           
        }

        public List<Instructor> GetListAll()
        {
            return _instructorDal.GetListAll();
        }

        public Instructor GetById(int id)
        {
            return _instructorDal.GetById(id);
        }

       


    }
}
