
using System;
using System.ComponentModel.Design;



static class TestStaticClass { }
public class ClassTest {  // eq private class
    #region Properties
    public int Ege { get; set; }
    public string Name { get; set; }

    private string CustomerAgeGroup { get; set; }
    #endregion

    #region Constructors
    //public ClassTest()
    //{
        
    //}
    public ClassTest( int age)
    {
        if (age < 18)
            CustomerAgeGroup = "child";
        else CustomerAgeGroup = "Adult";
    }
    #endregion

    #region Methods    
    public virtual int TestMethod(int val) {
        return val*2;
    }
    #endregion


}
public class ClassTestChild: ClassTest
{  // eq private class
    //public int Ege { get; set; }
    //public string Name { get; set; }
    public int Surname { get; set; }

    public ClassTestChild(int age):base(age)
    {
        
    }
    //public override int TestMethod(int val)
    //{
    //    return val * 5;
    //}

    public int TestMultiply(int val)
    {
        return TestMethod(val);
    }


}
//abstract class BaseClassTest { }
sealed class SealedClassTest { }   
class TestInheritanceSealed 
{ }
partial class PartialClassTest { public int MyProperty { get; set; } }
partial class PartialClassTest { public int MyProperty1 { get; set; } }
// public, private, protected, internal

class GFG
{
    void EmptyMethod() 
    { }
   static string StringMethodOut( out int lenStr)
    {
        var str = "test";
        lenStr = str.Length;
        return str;
    }
    static string StringMethodRef(ref int lenStr)
    {
        var str = "test";
        lenStr = str.Length;
        return str;
    }
    //----method overload--------------------------
    void FindCustomer(string pin) { }
    void FindCustomer(string name, string surname) { }

    // classes
    static public void Main(String[] args)
    {
        ClassTestChild childTest = new ClassTestChild(20);
        Console.WriteLine("ClassTestChild=>TestMethod ={0}", childTest.TestMethod(20));
        //childTest.
        ClassTest childTest1 = new ClassTest(15);
        Console.WriteLine("ClassTest=>TestMethod={0}", childTest1.TestMethod(20));

        childTest1 = childTest;

        ClassTest instance =  new ClassTest(20);
        instance.Name = "Anar";
        instance.Ege = 18;
        ClassTest instance1 = new ClassTest(20);
        instance1.Name = "Mahmud";
        instance1.Ege = 20;

    }

        ////--- ref out keywords------------------------------

        //static public void Main(String[] args) {
        //    int lenOut;
        // var resultOut =   StringMethodOut(out lenOut);
        //    Console.WriteLine(resultOut);
        //    Console.WriteLine(lenOut);
        //    int lenRef=0;
        //    //////////////////////////////////////////////////////
        //    var resultRef = StringMethodRef(ref lenRef);
        //    Console.WriteLine(resultRef);
        //    Console.WriteLine(lenRef);
        //    Console.ReadLine();
        //}
        #region 1-st lesson main method
        // Main Method
        //static public void Main(String[] args)
        //{
        //    // int, decimal, double, string, char, obejct, 
        //    int a = 5;
        //    string b = "hello";
        //    object val = null;
        //    val = a;
        //    val = b;
        //    Console.WriteLine(val);
        //    Console.ReadLine();
        //    TestMethod();
        //    //////////////////////////////////////////////
        //    // and , or, xor, not
        //    if (a == 5 || a == 6) // != 
        //    {
        //        // write ture code blocks
        //    }
        //    else if (true)
        //    {

        //    }
        //    else
        //    {

        //    }
        //    // if else yazilmis butun sertler bir-bir yoxlanilir
        //    string c = a == 5 ? "a 5-e beraberdir" : "a 5-den ferqlidir";
        //    //eq
        //    string c1 = string.Empty;
        //    if (a == 5)
        //    {
        //        c1 = "a 5-e beraberdir";
        //        c1 = "";
        //    }
        //    else
        //        c1 = "a 5-den ferqlidir";
        //    // dovler 3 cürdür
        //    // 1. Şətrsiz verilmiş say qədər icra olunan  (for)
        //    // 2. əvvəl şərt sonra cod bloku icra olunan dovr (while)
        //    // 3  cod bloku icra olunur sonunda şərt yoxlanan dövrlər (do-while)


        //}
        /// <summary>
        /// Test Mehtodo Descriptionu gostermek
        /// </summary>
        #endregion

        static void  TestMethod() { 

    }
}

namespace TestNameSpace
{

    
}