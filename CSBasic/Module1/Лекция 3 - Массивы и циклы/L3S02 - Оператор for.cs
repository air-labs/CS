using System;

public class L3S02
{
	public static void MainX()
	{
		var array=new int[5];
		
		for(int i=0;i<array.Length;i++)
			array[i]=2*i;
		
		foreach(var e in array)
			Console.Write ("{0} ",e);
		
		Console.WriteLine();
	}
}

//!for