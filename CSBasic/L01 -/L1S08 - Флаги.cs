using System;

enum Status
{
	Sent=1,
	Received=2,
	Replied=4
}

public class L1S08
{
	public static void MainX()
	{
		var status=Status.Sent;
		Console.WriteLine (status);
		
		status|=Status.Received;
		Console.WriteLine (status);
		
		status|=Status.Replied;
		Console.WriteLine (status);
		
		status&=~Status.Received;
		Console.WriteLine(status);
		
		Console.WriteLine ((status&Status.Received)==0);
		Console.WriteLine ((status&Status.Replied)==0);
	}		
}
