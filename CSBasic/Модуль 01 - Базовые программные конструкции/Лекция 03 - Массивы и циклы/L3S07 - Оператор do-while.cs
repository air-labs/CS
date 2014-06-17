using System;
using System.Linq;

public class L3S07
{
	public static void MainX()
	{
		var rnd=new Random();
		var forbidden=new int[]{1,2,4};
		int number=0;
		do
		{
			number=rnd.Next(5);
		} while(forbidden.Contains(number));
		
		Console.WriteLine(number);
	}
}
//!do-while