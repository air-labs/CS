using System;

public class L2S04
{
	static void TestNumber()
	{
		var number=int.Parse (Console.ReadLine ());
		Console.WriteLine ("A is even: {0}",number%2==0);
	}
	
	public static void MainX()
	{
		while(true)
		{
			try
			{
				TestNumber();
			}
			catch(Exception e)
			{
				Console.WriteLine("Something bad happens! {0}",e.Message);
			}
		}
	}
}

//!Всплывание исключения по стэку вызовов

