using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassExamBusiness.Entites
{
    public class Teacher:PersonBase
    {
        public string Education  { get; set; }

        public double Salary { get; set; } // 

        public int Experience { get; set; }
    }
}
