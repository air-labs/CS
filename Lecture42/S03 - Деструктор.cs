using System;
namespace L2S03
{
	public class FinalizableClass
	{
		int number;
		byte[] memory=new byte[1000000];
		
		public FinalizableClass(int number)
		{
			this.number=number;
			Console.ForegroundColor=ConsoleColor.Red;
			Console.WriteLine ("Object {0,2} is created",number);
		}
			
		~FinalizableClass() //деструктор - метод, который вызывается при сборке мусора
		{
			Console.ForegroundColor=ConsoleColor.Green;
			Console.WriteLine ("Object {0,2} is disposed",number);
		}
	}
	
	class Program
	{
		public static void MainX()
		{
			for (int i=0;i<10;i++)
				new FinalizableClass(i);
			
		}
        //видно, что деструктор вызывается неизвестно когда
	}
}
