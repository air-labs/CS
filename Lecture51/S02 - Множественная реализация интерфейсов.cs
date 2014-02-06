using System;
namespace L2S02
{

	public class Complex : ICloneable
	{
		public double Real { get; set; }
		public double Imaginary { get; set; }
		public object Clone() { return new Complex { Imaginary=Imaginary, Real=Real}; }
	}
	
	public class Angle : ICloneable, IComparable
	{
		public double Radian { get; set; }
		public object Clone() { return new Angle { Radian=Radian }; }
		public int CompareTo(object obj)
		{
			return Radian.CompareTo( (obj as Angle).Radian);
		}
	}
			                        
	class Program
	{
		public static void MainX()
		{
			var complex=new Complex();
			Console.WriteLine (complex is ICloneable);
			Console.WriteLine (complex is IComparable);
			
			var angle=new Angle();
			Console.WriteLine (angle is ICloneable);
			Console.WriteLine (angle is IComparable);
			
            var comparableAngle1 = angle as IComparable;
            var comparableAngle2 = (IComparable)angle;
            var comparableCOmplex1 = complex as IComparable;
            var comparableComplex2 = (IComparable)complex;
		}
	}
}
