using System.Collections.Generic;
using System;
namespace L2S01
{
	public static class IEnumerableExtensions
	{
		public static IEnumerable<Q> Select<T,Q>(this IEnumerable<T> enumerable, Func<T,Q> op)
		{
			foreach(var e in enumerable)
				yield return op(e);
		}
		
		public static IEnumerable<T> Where<T>(this IEnumerable<T> enumerable, Func<T,bool> op)
		{
			foreach(var e in enumerable)
				if (op(e))
					yield return e;
		}
	}
	
	public class Employee
	{
		public string Name { get; set; }
		public double Salary { get;set; }
	}
	
	public class Program
	{
		public static void Main()
		{
			var list=new List<Employee> { new Employee { Name="Smith",Salary=10000}, new Employee{Name="Jones",Salary=20000}, new Employee{Name="Williams",Salary=30000}};
			var data=list.Where (z=>z.Salary>10000).Select (z=>z.Name);
			foreach(var name in data)
				Console.WriteLine (name);
		}
	}
}

//! LINQ - как это работает? 