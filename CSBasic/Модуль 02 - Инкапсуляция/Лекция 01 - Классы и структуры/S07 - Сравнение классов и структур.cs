using System;
namespace S07
{
    public struct MyStruct
    {
        public int field;
    }

    public class MyClass
    {
        public int field;
    }

    public class SecondClass
    {
        public MyStruct structObject;
        public MyClass classObject;
    }

    public class Program
    {
        public static void MainX()
        {
            //Где произойдет исключение? Ответ внизу страницы.
            var obj = new SecondClass();
            Console.WriteLine(obj.structObject.field);
            Console.WriteLine(obj.classObject.field); 
        }
    }
}


























// в третьей строчке, т.к. obj.classField==null