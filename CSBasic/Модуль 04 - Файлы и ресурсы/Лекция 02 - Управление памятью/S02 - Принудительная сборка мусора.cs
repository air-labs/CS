using System;
class L2S02
{
	public static void MainX()
	{
		for (int i=0;i<20;i++)
		{
			var bytes=new byte[1000000];
			GC.Collect (); //принудительная сборка мусора
			Console.WriteLine (GC.GetTotalMemory(false));
		}
		
	}
}
