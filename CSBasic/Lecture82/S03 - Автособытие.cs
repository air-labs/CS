using System;
using System.Threading;
namespace L3S03
{
	public class Timer
	{
		public event Action<int> Tick;
		
		public void Start()
		{
			int time=0;
			while(true)
			{
				Tick(time++);
				Thread.Sleep(1000);
			}
		}
	}
	
	class Program
	{
		public static void MainX()
		{
			var timer=new Timer();
			timer.Tick += z=>Console.WriteLine(z);
			//timer.Tick(100); //ошибка: невозможно вызвать event
			timer.Start ();
		}	
	}	
}
