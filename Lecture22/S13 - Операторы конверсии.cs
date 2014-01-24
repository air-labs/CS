using System;
namespace S13
{
    public struct Salary
    {
        double sum;
        public Salary(double _sum) { sum = _sum; }
        public double Sum { get { return sum; } }
        public double Rub { get { return (int)sum; } }
        public double Kop { get { return sum - (int)sum; } }
        public override string ToString()
        {
            return string.Format("{0:0.00}R", Sum);
        }

        public static implicit operator double(Salary sal)
        {
            return sal.Sum;
        }

        public static explicit operator Salary(double sum)
        {
            return new Salary(sum);
        }
    }

    class Program
    {
        public static void MainX()
        {
            //Salary salary = 10000.50; //так делать нельзя, поскольку конверсия explicit
            Salary salary = (Salary)10.50;
            Console.WriteLine(salary); //это работает неправильно, потому что salary переходит в double
            Console.WriteLine(salary.ToString());
            
            double floating = salary;
            Console.WriteLine(floating);

            floating = salary * 10;
            Console.WriteLine(floating);
            
            //salary = salary * 10; //так делать нельзя, поскольку конверсия explicit
            salary = (Salary)(salary * 10);
            Console.WriteLine(salary.ToString());
        }
    }
}