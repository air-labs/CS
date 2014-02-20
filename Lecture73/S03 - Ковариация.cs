using System;
namespace L3S02
{
    public class Person { }
    public class Employee : Person { }
    public class Manager : Employee { }

    public interface ISource<out T>
    {
        T GetByID(int ID);
    }

    public class Source<T> : ISource<T>
    {
        public T GetByID(int id) { throw new NotImplementedException(); }
    }

    class Program
    {
        public static void MainX()
        {
            var p = new Source<Employee>();
            Console.WriteLine(p is ISource<Employee>);
            Console.WriteLine(p is ISource<Person>);
            Console.WriteLine(p is ISource<Manager>);
        }
    }
}
