


using AbstractClassesAndInterfaces.Factory;
using AbstractClassesAndInterfaces.Interfaces;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace AbstractClassesAndInterfaces
{

    public static class StartClass {

        static public void Main(String[] args)
        {
            IMyInterface myInterfaceInstance = null;
            string customerType = GetCustomerType(1);
            if (customerType == "Corporate")
                myInterfaceInstance = new MyInterfaceImpA();
            else
                myInterfaceInstance = new MyInterfaceImp();

            AdddData(myInterfaceInstance, "My Json data, Entity Class etc");

            //IMyInterface myInterfaceInstance = new MyInterfaceImp();
            //myInterfaceInstance.Add("Anar");
            //var length =   myInterfaceInstance.GetListLength();

            //myInterfaceInstance = new MyInterfaceImpA();
            //myInterfaceInstance.Add("Mahmud");
            //var lengthA = myInterfaceInstance.GetListLength();
        }


        static void AdddData(IMyInterface instance, string customerData) {
            string CustomerData = "CustomerData...";
            instance.Add(CustomerData);

        }


        static string GetCustomerType(int type) {
        if (type == 1)
            return "Corporate";
        else
            return "Private person";
    }

        }

    


}