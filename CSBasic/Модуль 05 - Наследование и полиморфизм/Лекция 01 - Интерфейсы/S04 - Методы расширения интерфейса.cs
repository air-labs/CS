using System;
namespace L2S04
{
	public interface IPrintable
	{
		void Print();	
		ConsoleColor Color { get; }
	}
	
    //В интерфейс можно добавлять методы расширения
	public static class IPrintableExtensons
	{
		public static void PrintWithColor(this IPrintable prn)
		{
			Console.ForegroundColor=prn.Color;
			prn.Print ();
		}
	}
	
	public class Person : IPrintable
	{
		public string Name { get; set; }
		public int Age { get; set; }
		public void Print()
		{
			Console.WriteLine("{0} ({1} y.o)",Name,Age);
		}
		public ConsoleColor Color { get { return ConsoleColor.Red; } }
	}
	
	class Program
	{
		public static void MainЧ()
		{
			new Person{ Name="Smith", Age=20 }.PrintWithColor ();
		}
	}
}

//!Экстеншн интерфейса