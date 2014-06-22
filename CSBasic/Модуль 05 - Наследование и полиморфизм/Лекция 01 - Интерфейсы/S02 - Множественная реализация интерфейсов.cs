using System;
namespace L2S02
{

    public class Complex : ICloneable
    {
        public double Real { get; set; }
        public double Imaginary { get; set; }
        public object Clone() { return new Complex { Imaginary = Imaginary, Real = Real }; }
    }

    public class Angle : ICloneable, IComparable
    {
        public double Radian { get; set; }
        public object Clone() { return new Angle { Radian = Radian }; }
        public int CompareTo(object obj)
        {
            return Radian.CompareTo((obj as Angle).Radian);
        }
    }

    class Program
    {
        public static void Process(object unknown)
        {
            Console.WriteLine(unknown is ICloneable);
            Console.WriteLine(unknown is IComparable);
            IComparable comparable1 = unknown as IComparable;
            IComparable comparable2 = (IComparable)unknown;

        }

        public static void Main()
        {
            Process(new Angle { Radian = 1 });
            Process(new Complex { Imaginary = 1, Real = 1 });
        }
    }
}
