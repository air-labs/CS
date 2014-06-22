using System;
using System.Threading;
class L2S03
{
	static void Calc()
    {
		int sum=0;
		for (int i=0;i<100;i++)
		{
			sum+=i;
			Thread.Sleep (30);
		}
		Console.WriteLine ("\n{0}\n",sum);
		
	}
	
	public static void MainX()
	{
		new Action(Calc).BeginInvoke (null,null);
		
		while(true)
		{
			Console.Write (".");
			Thread.Sleep (30);
		}
	}
}
