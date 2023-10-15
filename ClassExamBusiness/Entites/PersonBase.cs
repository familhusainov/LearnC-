using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassExamBusiness.Entites
{
    public class PersonBase
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string MidName { get; set; }
        public int Age { get; set; }
    }
}
