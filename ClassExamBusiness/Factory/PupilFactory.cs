using ClassExamBusiness.Entites;
using ClassExamBusiness.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassExamBusiness.Factory
{
    public class PupilFactory : BaseFactory, IPerson<Pupil>
    {
        public static List<Pupil> PupilList;
        public void Add(Pupil data)
        {
            PupilList.Add(data);
        }

        //public void AddPupil()
        //{
        //    throw new NotImplementedException();
        //}

        ////public void AddTeacher()
        ////{
        ////    throw new NotImplementedException();
        ////}

        public void Delete(int Id)
        {
           PupilList.RemoveAt(Id);
        }
    }
}
