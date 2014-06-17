using System;
using System.Linq;

public class L3S08
{
	public static void MainX()
	{
		var rnd=new Random();
		var forbidden=new int[]{1,2,4};
		int number=0;
		while(true)
		{
			number=rnd.Next(5);
			if (!forbidden.Contains(number)) break;
		}
		
		Console.WriteLine(number);
	}
}
