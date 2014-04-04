using System;
namespace L1S02
{
    public class Person
    {
        public string Name { get; set; }

    }

    public class Client : Person
    {
        public string ManagerName { get; set; }
    }

    class Program
    {
        public static void MainX()
        {
            Client client = new Client { Name = "Petrov", ManagerName = "Sidorov" };
            Person person = new Person { Name = "Ivanov" };

            Console.WriteLine(client is Person);
            Console.WriteLine(person is Person);
            Console.WriteLine(client is Client);
            Console.WriteLine(person is Client);

            Person clientAsPerson = client;
            Client correctClient1 = clientAsPerson as Client;
            Client correctClient2 = (Client)clientAsPerson;
            Client incorrectClient = (Client)person; //выкинет исключение, т.к. person не является Client
        }
    }
}

//!Операторы is и as
        