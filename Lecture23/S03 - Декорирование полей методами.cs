using System;
namespace S03
{
    public class Employee
    {
        private int salary;
        public int GetSalary() { return salary; }
        public void SetSalary(int salary)
        {
            if (salary < 0)
                throw new ArgumentException();
            this.salary = salary;
        }
    }

    class Program
    {
        public static void MainX()
        {
            var emp = new Employee();
            emp.SetSalary(10000);
            emp.SetSalary(emp.GetSalary() * 2);
            // emp.salary*=2; //нельзя, так как это требует доступа к полю
        }
    }
}

//!Классическая Java-инкапсуляция: все поля закрыты, наружу торчат только методы