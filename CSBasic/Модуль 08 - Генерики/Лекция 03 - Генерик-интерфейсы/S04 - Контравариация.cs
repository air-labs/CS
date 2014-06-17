using System;
namespace L3S03
{
	public class Person {}
	public class Employee : Person {}
	public class Manager : Employee {}
	
	public interface IReceiver<in T>
	{
		void Save(T obj);
	}
	
	public class Receiver<T> : IReceiver<T>
	{
		public void Save(T obj) { throw new NotImplementedException(); }
	}
	
	class Program
	{
		public static void Main()
		{
			var p=new Receiver<Employee>();
			Console.WriteLine(p is IReceiver<Employee>);
			Console.WriteLine(p is IReceiver<Person>);
			Console.WriteLine(p is IReceiver<Manager>);
		}
	}
	
}
//!Контравариация