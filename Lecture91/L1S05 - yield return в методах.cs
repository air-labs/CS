using System.Collections.Generic;
using System;
class L1S05
{
	static IEnumerable<int> GetInts(int Max)
	{
		for (int i=0;i<=Max;i++)
			yield return i;
	}
	
	public static void MainX()
	{
		foreach(var e in GetInts (10))
			Console.WriteLine(e);
	}
}

//!yield метод