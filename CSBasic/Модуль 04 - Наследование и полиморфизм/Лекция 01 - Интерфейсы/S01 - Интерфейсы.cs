using System;
namespace L2S01
{
    //Интерфейс - это набор требований к программе
	public interface IPrintable
	{
		void Print();	
	}
	
	public class Person : IPrintable
	{
		public string Name { get; set; }
		public int Age { get; set; }
		public void Print()
		{
			Console.WriteLine("{0} ({1} y.o)",Name,Age);
		}
	}
	
	public class Enterprise : IPrintable
	{
		public string Name { get; set; }
		public string Organisation { get; set; }
		public void Print()
		{
			Console.WriteLine("{0} ({1})",Name,Organisation);
		}
	}
	
	class Program
	{
		static void Print(IPrintable prn)
		{
			prn.Print ();
		}
		
		public static void MainX()
		{
			Print (new Person{ Name="Smith", Age=20 });		
			Print (new Enterprise { Name="ACME", Organisation="Ltd" });
		}
	}
}