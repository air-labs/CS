using System;
namespace S08
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
        public static void MainX()
        {
            var structArray = new MyStruct[10];
            Console.WriteLine(structArray[0].field);

            var classArray = new MyClass[10];
            Console.WriteLine(classArray[0].field); //исключение - элемент массива не инициализирован
            
        }
    }
}
