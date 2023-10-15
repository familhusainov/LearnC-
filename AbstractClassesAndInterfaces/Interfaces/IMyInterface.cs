using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassesAndInterfaces.Interfaces
{
    public interface IMyInterface
    {
        public void ReadText(int index);
        public void EditText(int index, string newText);
        public void DeleteText(int index);
        public void Add(string text);

        public int GetListLength();
    }
}
