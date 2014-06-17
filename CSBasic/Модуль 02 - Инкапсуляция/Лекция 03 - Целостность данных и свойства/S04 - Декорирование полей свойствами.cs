using System;
namespace L4S03
{
    public class Employee
    {
        double salary;
        public double Salary
        {
            get
            {
                //Console.WriteLine("Getting salary {0}", salary);
                return salary;
            }
            set
            {
                if (value < 0) throw new ArgumentException();
                //Console.WriteLine("Setting salary to {0}", value);
                salary = value;
            }
        }
    }

    class Program
    {
        public static void MainX()
        {
            var emp = new Employee();
            emp.Salary = 10000;
            emp.Salary *= 2;
            Console.WriteLine(emp.Salary);
        }
    }
}