using System;
namespace L1S03
{
    public class Person
    {
        public string Name { get; set; }
        public virtual void Print()
        {
            Console.WriteLine(Name);
        }
    }

    public class Client : Person
    {
        public string ManagerName { get; set; }
        public override void Print()
        {
            Console.WriteLine(Name);
            Console.WriteLine("Менеджер: {0}", ManagerName);
        }
    }

    class Program
    {
        public static void MainX()
        {
            Person person = new Person { Name = "Ivanov" };
            person.Print();

            Client client = new Client { Name = "Petrov", ManagerName = "Sidorov" };
            client.Print();

            Person clientAsPerson = (Person)client;
            clientAsPerson.Print();
        }
    }
}