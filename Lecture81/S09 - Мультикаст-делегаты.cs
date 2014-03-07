using System;
class L1S08
{
	public static void MainX()
	{
		Action<int> action=null;
		action+=a=>
		{
			Console.ForegroundColor= ConsoleColor.Red;
			Console.WriteLine (a);
		};
		
		action+=a=>
		{
			Console.ForegroundColor= ConsoleColor.Green;
			Console.WriteLine (a);
		};
		
		for (int i=0;i<5;i++) action(i);
	}
	
}
