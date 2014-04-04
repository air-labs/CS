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
            var obj = new SecondClass();
            Console.WriteLine(obj.structObject.field);
            Console.WriteLine(obj.classObject.field); //исключение: obj.classObject неопределен
        }
    }
}
