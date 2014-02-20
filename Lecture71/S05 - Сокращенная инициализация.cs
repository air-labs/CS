using System.Collections.Generic;
namespace L1S05
{
    public class Employee
    {
        public string Name { get; set; }
        public double Salary { get; set; }
        public List<Employee> Subordinates { get; set; }
    }

    class Program
    {
        public static void MainX()
        {
            var intList = new List<int> { 1, 2, 3, 4, 5 };
            var salaries=new Dictionary<string,double>
            {
                {"Smith",10000},
                {"Jones",20000}
            };

            var emp=new Employee
            {
                Name="Smith",
                Salary=50000,
                Subordinates=new List<Employee>
                {
                    new Employee
                    {
                        Name="Jones",
                        Salary=20000
                    },
                    new Employee
                    {
                        Name="Williams",
                        Salary=30000
                    }
                }
            };
        }
    }
}

//!Инициализация генерик-листов и словарей