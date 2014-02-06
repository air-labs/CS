using System;
namespace L1S05
{
    public class Person
    {
        public string Name { get; private set; }
        public Person(string Name)
        {
            this.Name = Name;
        }
        public virtual void Print()
        {
            Console.WriteLine(Name);
        }
    }

    public class Client : Person
    {
        public string ManagerName { get; private set; }

        public Client(string Name, string ManagerName)
            : base(Name)
        {
            this.ManagerName = ManagerName;
        }

        public new void Print()
        {
            base.Print();
            Console.WriteLine("Менеджер: {0}", ManagerName);
        }
    }

    class Program
    {
        public static void MainX()
        {
            Person person = new Person("Ivanov");
            person.Print();
          
            Client client = new Client("Petrov", "Sidorov");
            client.Print();

            Person clientAsPerson = (Person)client;
            clientAsPerson.Print();


        }
    }
}