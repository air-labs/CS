﻿using System;

public class L2S01
{
	public static void Main()
	{
		var a=int.Parse (Console.ReadLine());
		
		if (a==0) Console.WriteLine ("A is zero");
		
		if (a%2==0) Console.WriteLine ("A is odd");
		else Console.WriteLine ("A is even");
		
		if (a<0) Console.WriteLine ("A is negative");
		else if (a<10) Console.WriteLine ("A consists of one digit");
		else
		{
			var num=a.ToString ().Length;
			Console.WriteLine ("The number of digits in A is {0}",num);
			if (a>1000)
				Console.Write ("A is enormous!");
		}
	}
}
