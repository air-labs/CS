using System;
namespace S12
{
    public struct Angle
    {
        double radian;
        public double Radian { get { return radian; } }
        public double Gradus { get { return radian * 180 / Math.PI; } }
        public Angle(double _radian) { radian = _radian; }

        public override string ToString()
        {
            return string.Format("{0}o",Gradus);
        }

        public static Angle operator *(Angle angle, double c)
        {
            return new Angle(angle.Radian * c);
        }

        public static Angle operator *(double c, Angle angle)
        {
            return new Angle(angle.Radian * c);
        }

        public static double operator /(Angle arg1, Angle arg2)
        {
            return arg1.Radian / arg2.Radian;
        }
    } 

    class Program
    {
        public static void MainX()
        {
            var a = new Angle(Math.PI / 8);
            var b = a * 2;
            a *= 4;
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(a / b);
        }
    }
}