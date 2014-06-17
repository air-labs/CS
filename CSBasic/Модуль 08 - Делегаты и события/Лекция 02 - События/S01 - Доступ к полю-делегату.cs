using System;
using System.Threading;
namespace L3S01
{
	public class Timer
	{
        public int Interval = 1000;
		public Action<int> Tick { get; set; }
		public void Start()
		{
			int time=0;
			while(true)
			{
				Tick(time++);
				Thread.Sleep(Interval);
			}
		}
	}
	
	class Program
	{
		public static void Main()
		{
			var timer=new Timer();
			timer.Tick=z=>Console.WriteLine(z);
			timer.Tick(100);
			timer.Start ();
		}	
	}	
}
