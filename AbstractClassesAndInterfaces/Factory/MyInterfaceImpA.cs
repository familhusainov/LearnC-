using AbstractClassesAndInterfaces.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassesAndInterfaces.Factory
{
    public class MyInterfaceImpA : IMyInterface
    {
        public List<string> Alist { get; set; }
        public void Add(string text)
        {
            throw new NotImplementedException();
        }

        public void DeleteText(int index)
        {
            throw new NotImplementedException();
        }

        public void EditText(int index, string newText)
        {
            throw new NotImplementedException();
        }

        public void ReadText(int index)
        {
            throw new NotImplementedException();
        }

        public int GetListLength()
        {
            return (Alist.Count())*5;
        }
    }
}
