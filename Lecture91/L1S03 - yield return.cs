using System.Collections.Generic;
using System;
namespace L1S03
{
	public class MyEnumerable : IEnumerable<int>
	{
		public int Max { get; set; }
				
		public IEnumerator<int> GetEnumerator ()
		{
			for(int i=0;i<=Max;i++)
				yield return i;
		}
	
		System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator ()
		{
			return GetEnumerator ();
		}
	}
	
	class Program
	{
		public static void MainX()
		{
			var en=new MyEnumerable { Max=10 };
			foreach(var e in en)
				Console.Write("{0} ",e);
		}
	}
	
}

//!Реализация интерфейса через yield