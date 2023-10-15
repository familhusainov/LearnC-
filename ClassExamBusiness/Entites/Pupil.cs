using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassExamBusiness.Entites
{
    public class Pupil : PersonBase
    {
        public string Grade { get; set; }

        public bool Attendance { get; set; }

    }
}
