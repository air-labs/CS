using System;
namespace L3S02
{
	public class HelpAttribute : Attribute
	{
		public string Message { get; private set; }
		public HelpAttribute(string Message)
		{
			this.Message=Message;
		}
	}
	
	public class Employee
	{
       // Атрибуты - хранение дополнительной информации о коде программы
		[Help("The name of the person")]
		public string Name { get; set; }
	}
	
	public class Program
	{
		public static void MainX()
		{
			var type=typeof(Employee);
			var prop=type.GetProperty ("Name");
			var attr=(HelpAttribute)prop.GetCustomAttributes (true)[0];
			Console.WriteLine (attr.Message);
		}
	}
	
}

	
	
	
