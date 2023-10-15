using ClassExamBusiness.Entites;
using ClassExamBusiness.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassExamBusiness.Factory
{
    public class TeacherFactory : BaseFactory, IPerson<Teacher>
    {
        public static List<Teacher> TeacherList;
      
        public void Add(Teacher data)
        {
            TeacherList.Add(data);
        }

        public void Delete(int Id)
        {
            throw new NotImplementedException();
        }
    }
}
