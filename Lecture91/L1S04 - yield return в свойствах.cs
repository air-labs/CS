using System;
using System.Collections.Generic;
namespace L1S04
{
	public class MyEnumerable
	{
		public int Max { get; set; }
		
		public IEnumerable<int> Ascending 
		{
			get
			{
				for (int i=0;i<=Max;i++)
					yield return i;
			}
		}
		
		public IEnumerable<int> Descending
		{
			get
			{
				for (int i=Max;i>=0;i--)
					yield return i;
			}
		}
	}
	
	class Program
	{
		public static void MainX()
		{
			var en=new MyEnumerable { Max=10};
			foreach(var e in en.Ascending)
				Console.Write("{0} ",e);
			Console.WriteLine();
			
			foreach(var e in en.Descending)
				Console.Write ("{0} ",e);
			
		}
	}		
				
		
	
}

//!yield свойства