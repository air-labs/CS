using System;
using System.Threading;
namespace L3S02
{
	public class Timer
	{
        int interval=1000;
        public int Interval
        {
            get { return interval; }
            set
            {
                if (value < 0) throw new ArgumentException();
                interval = value;
            }
        }

		Action<int> tick;
		
		public event Action<int> Tick
		{
			add { tick+=value; }
			remove { tick-=value; }
		}
		
		public void Start()
		{
			int time=0;
			while(true)
			{
				// Tick(time++); //ошибка: невозможно вызвать event
				tick(time++);
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
