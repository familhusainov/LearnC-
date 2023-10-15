using ClassExamBusiness.Entites;
using ClassExamBusiness.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassExamBusiness.Factory
{
    public class TechnicalStaffFactory : IPerson<TechnicalStaff>
    {
        public static List<TechnicalStaff> TechnicalStaffList;
        public void Add(TechnicalStaff data)
        {
            TechnicalStaffList.Add(data);
        }

        public void Delete(int Id)
        {
            throw new NotImplementedException();
        }
    }
}
