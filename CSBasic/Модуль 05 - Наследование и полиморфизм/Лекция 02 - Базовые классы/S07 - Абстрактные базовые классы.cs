using System;
namespace L1S06
{
    public abstract class Person
    {
        public string Name { get; set; }
        public abstract void Print();
    }

    public class Employee : Person
    {
        public override void Print()
        {
            Console.WriteLine(Name);
        }
    }

    class Program
    {
        public static void MainX()
        {
            //var person=new Person(); //ошибка - нельзя создать экземляр абстрактного класса
            var employee = new Employee { Name = "Smith" };
            employee.Print();
        }
    }
}