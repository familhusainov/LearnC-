using ClassExamBusiness.Entites;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassExamBusiness.Interfaces
{
    public interface IPerson<T>
    {
        public void Add(T data);
        public void Delete(int Id);

        public string GetFullName();

        //public void AddPupil();
        //public void AddTeacher();

    }
}
