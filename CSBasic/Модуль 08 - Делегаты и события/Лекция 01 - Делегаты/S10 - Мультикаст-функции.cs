using System;
class L1S09
{
	public static void MainX()
	{
		Func<int,int> function=null;
		function+=x=>2*x;
		function+=x=>3*x;
		Console.WriteLine(function(1));
	}
}
