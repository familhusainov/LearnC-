using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassesAndInterfaces.Classes
{
    public abstract class AbstractClass
    {
        public abstract void ReadText(int index);
        public abstract void EditText(int index, string newText);
        public abstract void DeleteText(int index);
        public abstract void Add(string text);
        public abstract int GetListLength();


        public int GetAge(int yearOfBirth) { 
        
            return DateTime.Now.Year - yearOfBirth;        
        }

        public  virtual string GetCustomerAddress(int cityCode=10 ) {
          /// default implementation
            return "Baku";
        }
    }
}
