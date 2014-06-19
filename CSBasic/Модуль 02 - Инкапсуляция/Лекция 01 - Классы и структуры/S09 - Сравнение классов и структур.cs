using System;
namespace L1S10
{
    public struct MyStruct
    {
        public int field;
    }

    public class MyClass
    {
        public int field;
    }

    public class Program
    {
        static void ProcessStruct(MyStruct s)
        {
            s.field = 10;
        }
        static void ProcessClass(MyClass s)
        {
            s.field = 10;
        }


        public static void MainX()
        {
            //Что напечатает программа?
            var str = new MyStruct();
            ProcessStruct(str);
            Console.WriteLine(str.field);

            var obj = new MyClass();
            ProcessClass(obj);
            Console.WriteLine(obj.field);
        }
    }
}


























//0 10, т.к. структура копируется при передаче в метод