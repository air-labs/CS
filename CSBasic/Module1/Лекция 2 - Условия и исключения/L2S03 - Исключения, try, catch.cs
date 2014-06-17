using System;

public class L2S03
{
	public static void MainX()
	{
		while(true)
		{
			try
			{
				var number=int.Parse (Console.ReadLine ());
				Console.WriteLine ("A is even: {0}",number%2==0);
			}
			catch(Exception e)
			{
				Console.WriteLine("Something bad happens! {0}",e.Message);
			}
		}
	}
}

//!try-catch

