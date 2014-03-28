using System.Collections.Generic;
using System.Collections;
using System;
namespace L1S02
{
	public class Program
	{
		public static void MainX()
		{
			var en=new MyEnumerable { Max=10 };
			foreach(var e in en)
				Console.Write("{0} ",e);
		}
	}
	
	public class MyEnumerable : IEnumerable<int>
	{
		public int Max { get; set; }
		
		
		public IEnumerator<int> GetEnumerator ()
		{
			return new MyEnumerator(this);
		}
		
		System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator ()
		{
			return GetEnumerator();
		}
	}		
	
	public class MyEnumerator : IEnumerator<int>
	{
		MyEnumerable enumerable;
		int current;
		
		public MyEnumerator(MyEnumerable enumerable)
		{
			this.enumerable=enumerable;
			current=-1;
		}
		
		public int Current {
			get {
				return current;
			}
		}

		public bool MoveNext ()
		{
			current++;
			return Current<=enumerable.Max;
		}

		public void Reset ()
		{
			current=-1;
		}

		object IEnumerator.Current {
			get {
				return current;
			}
		}

		public void Dispose ()
		{
			
		}
		
	}
}

//!Реализация интерфейса вручную