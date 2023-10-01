
using System;
using System.ComponentModel.Design;

class GFG
{

    // Main Method
    static public void Main(String[] args)
    {
        // int, decimal, double, string, char, obejct, 
        int a = 5;
        string b = "hello";
        object val = null;
        val = a;   
        val = b;
        Console.WriteLine(val);
        Console.ReadLine();
        TestMethod();
        //////////////////////////////////////////////
        // and , or, xor, not
        if (a==5 || a==6) // != 
        {
            // write ture code blocks
        }
        else if (true) 
        {
        
        }
        else 
        {
        
        }
        // if else yazilmis butun sertler bir-bir yoxlanilir
        string c = a == 5 ? "a 5-e beraberdir" : "a 5-den ferqlidir";
        //eq
        string c1 = string.Empty;
        if (a == 5)
        {
            c1 = "a 5-e beraberdir";
            c1 = "";
        }
        else
            c1 = "a 5-den ferqlidir";
        // dovler 3 cürdür
        // 1. Şətrsiz verilmiş say qədər icra olunan  (for)
        // 2. əvvəl şərt sonra cod bloku icra olunan dovr (while)
        // 3  cod bloku icra olunur sonunda şərt yoxlanan dövrlər (do-while)

       
    }
    /// <summary>
    /// Test Mehtodo Descriptionu gostermek
    /// </summary>
     static void  TestMethod() { 

    }
}
