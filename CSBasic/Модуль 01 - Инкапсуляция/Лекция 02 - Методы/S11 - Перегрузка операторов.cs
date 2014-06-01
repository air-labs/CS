using System;
namespace S11
{
    public struct Complex
    {
        public double Real { get; set; }
        public double Imaginary { get; set; }

        public override string ToString()
        {
            return string.Format("{0}+{1}i", Real, Imaginary);
        }

        public Complex(double real, double imaginary) : this()
        {
            Real = real;
            Imaginary = imaginary;
        }

        public static Complex operator +(Complex arg1, Complex arg2)
        {
            return new Complex
            {
                Real = arg1.Real + arg2.Real,
                Imaginary = arg1.Imaginary + arg2.Imaginary
            };
        }
    }

    public class Program
    {
        public static void MainX()
        {
            var x = new Complex(1, 0);
            var y = new Complex(0, 1);
            Console.WriteLine(x + y);
        }
    }
}