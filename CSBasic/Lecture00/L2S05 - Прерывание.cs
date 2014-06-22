
using System;
using System.Threading;
class L2S05
{
	static int Calc()
    {
		int sum=0;
		for (int i=0;i<100;i++)
		{
			sum+=i;
			Thread.Sleep (30);
		}
		return sum;
	}
	
	
	public static void MainX()
	{
		var action=new Func<int>(Calc);
		var asyncResult=action.BeginInvoke (result=>Console.WriteLine (action.EndInvoke (result)),null);
		
		while(true)
		{
			Console.Write (".");
			Thread.Sleep (30);
		}
	}
}
