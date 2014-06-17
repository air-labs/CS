using System;

public class L3S06
{
	public static void MainX()
	{
		int number=0;
		while(number<30)
		{
			if (number%3==0) number+=4;
			else if (number%5==0) number-=9;
			else number+=2;
			Console.WriteLine(number);
		}
	}	
}
