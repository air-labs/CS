using System;
using System.Reflection;
namespace L3S01
{
	public class Employee
	{
		public string Name { get; set; }
		double salary;
		public void Print()
		{
			Console.WriteLine("{0}\t{1}",Name,salary);
		}
	}
	
	class Program
	{
		public static void Main()
		{
			var type=typeof(Employee);
			var obj=type.GetConstructor (new Type[0]).Invoke (new object[0]);
			
			type.GetProperty ("Name").SetValue (obj,"Smith",new object[0]);
			
			type.GetField ("salary",BindingFlags.NonPublic | BindingFlags.Instance)
				.SetValue (obj,10000);
			
			type.GetMethod("Print").Invoke (obj,new object[0]);
			
			
			
		}
	}
}
//!Рефлексия позволяет делать все, что делает программа, и даже больше: например, работать с закрытыми полями
		
		
