using System;

enum Days
{
	Monday,
	Tuesday,
	Sunday
}

public class L1S07
{
	public static void MainX()
	{
		var day=Days.Tuesday;
		
		int dayNumber=(int)day;
		day=(Days)dayNumber+1;
		
		Console.WriteLine (day);
		day=(Days)Enum.Parse(typeof(Days),"Monday");
		Console.WriteLine (day);
	}
}
