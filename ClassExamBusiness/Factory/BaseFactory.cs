using ClassExamBusiness.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassExamBusiness.Factory
{
   public   class BaseFactory
    {
        public string GetFullName(PersonBase person)
        {
            return person.Name + " " + person.Surname;
        }

        public string GetFullName1(PersonBase person)
        {
            return person.Name + " " + person.Surname;
        }
    }
}
