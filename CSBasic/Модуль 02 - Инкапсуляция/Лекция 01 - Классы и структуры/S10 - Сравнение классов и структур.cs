using System;
namespace S10
{
    public class MyClass
    {
        public int classField;
    }

    public struct MyStruct
    {
        public MyClass myObject;
    }

    public class Program
    {
        public static void ProcessStruct(MyStruct str)
        {
            str.myObject.classField = 10;
        }

        public static void MainX()
        {
            //Что напечатает программа?
            var str = new MyStruct();
            str.myObject = new MyClass();
            ProcessStruct(str);
            Console.WriteLine(str.myObject.classField);
        }
    }
}
























// 10, т.к. ссылка на объект скопировалась при копировании структуры, а объект - тот же.