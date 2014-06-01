using System;
namespace L1S01
{
    public class Person
    {
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
    }

    public class Employee : Person
    {
        public string Position { get; set; }
    }

    public class Client : Person
    {
        public Employee Manager { get; set; }
    }

    // public class StrangePerson : Client, Employee { } //множественное наследование запрещено

    class Program
    {
        public static void Main()
        {
            var client = new Client();
            client.Name = "Ivanov";

            client.Manager = new Employee();
            client.Manager.Position = "Sales manager";
        }
    }
}