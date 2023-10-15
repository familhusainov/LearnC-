using AbstractClassesAndInterfaces.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AbstractClassesAndInterfaces.Factory
{
    public class MyInterfaceImp : IMyInterface
    {
        public List<string> MyList = new List<string>();
        public void DeleteText(int index)
        {
           MyList.RemoveAt(index);
        }

        public void EditText(int index, string newText)
        {
            MyList.ToArray()[index]=newText;
        }

        public void ReadText(int index)
        {
            Console.WriteLine(MyList.ElementAt(index));
        }
        public void Add(string text) { 
          MyList.Add(text);
        }

        public int GetListLength()
        {
           return  MyList.Count();
        }
    }
}
