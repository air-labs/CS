using System;
namespace L3S01
{
	public class Person {}
	public class Employee : Person {}
	public class Manager : Employee {}
	
	public interface IProcessor<T>
	{
		T GetByID(int ID);
		void Save(T obj);
	}
	
	public class Processor <T> : IProcessor<T>
	{
		public T GetByID(int id) { throw new NotImplementedException(); }
		public void Save(T obj) { throw new NotImplementedException(); }
	}
	
	class Program
	{
		public static void MainЧ()
		{
			var p=new Processor<Employee>();
			Console.WriteLine(p is IProcessor<Employee>);
			Console.WriteLine(p is IProcessor<Person>);
			Console.WriteLine(p is IProcessor<Manager>);
		}
	}
	
}
