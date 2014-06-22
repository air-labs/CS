
using System;
using System.Threading;
class L2S04
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
		var asyncResult=action.BeginInvoke (null,null);
		
		while(!asyncResult.IsCompleted)
		{
			Console.Write (".");
			Thread.Sleep (30);
		}
		var result=action.EndInvoke (asyncResult);
		Console.WriteLine (result);
	}
}