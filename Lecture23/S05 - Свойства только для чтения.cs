using System;
namespace S05
{
    public class Employee
    {
        double salary;

        public double Salary
        {
            get
            {
                return salary;
            }
        }

        public void SetSalary(double basicSalary, double premie)
        {
            salary = basicSalary + premie;
            if (salary < 0) throw new ArgumentException();
        }

    }
}