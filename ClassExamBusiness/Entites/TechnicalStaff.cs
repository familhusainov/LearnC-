using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassExamBusiness.Entites
{
    public class TechnicalStaff:PersonBase
    {
        public string Position { get; set; }

        public string Department { get; set; }
    }
}
