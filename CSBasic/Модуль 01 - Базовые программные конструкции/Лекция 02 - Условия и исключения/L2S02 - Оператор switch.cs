﻿using System;

public class L2S02
{
	public static void MainX()
	{
		var y=10;
		var symbol='1';
		
		while(true)
		{
			Console.CursorLeft=30;
			Console.CursorTop=y;
			Console.Write (symbol);
			
			var key=Console.ReadKey(true);
			switch(key.Key)
			{
				case ConsoleKey.UpArrow : 
					y--; 
					break;
				case ConsoleKey.DownArrow : 
					y++; 
					break;
				
				case ConsoleKey.Escape:
				case ConsoleKey.Spacebar:
					return;
				
				default:
					symbol=
						symbol=='1'?'2':'1';
				break;
			}
		}
	}
}
