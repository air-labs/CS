using System;

public class L1S06
{
		
	public static void MainX()
	{
		int a=1,b=2,c=3;
		var res1=a+b*(c-b/2)%2;

        a = b = c;

        a *= 3;

        a = 1;
        Console.WriteLine(a++);
        a = 1;
        Console.WriteLine(++a);
			
		bool x=true, y=false;
		var res2=x && !(y || (a>2) );
	}
}
