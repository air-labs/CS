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
            //Где произойдет исключение? Ответ внизу страницы.
            var structArray = new MyStruct[10];
            Console.WriteLine(structArray[0].field);

            var classArray = new MyClass[10];
            Console.WriteLine(classArray[0].field);
            
        }
    }
}

























// в четвертой строчке, т.к. массив classArray заполнен null