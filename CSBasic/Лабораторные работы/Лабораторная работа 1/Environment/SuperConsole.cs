using System;


	public class SuperConsole
	{
		public static void Line(int length=10)
		{
			for (int i=0;i<length;i++)
				Console.Write (Symbols.lr);
			Console.WriteLine ();
		}
	
	public static void Put(int x, int y, char c, ConsoleColor foreColor=ConsoleColor.Gray, ConsoleColor backColor=ConsoleColor.Black)
	{
		Console.CursorTop=y;
		Console.CursorLeft=x;
		Console.ForegroundColor=foreColor;
		Console.BackgroundColor=backColor;
		Console.Write (c);
	}
	
	public static void Print(int x, int y, string str,ConsoleColor foreColor=ConsoleColor.Gray, ConsoleColor backColor=ConsoleColor.Black)
	{
		Console.CursorTop=y;
		Console.CursorLeft=x;
		Console.ForegroundColor=foreColor;
		Console.BackgroundColor=backColor;
		Console.Write (str);
		
	}
	
	public static void DoubleFrame(int x0, int y0, int x1, int y1, ConsoleColor foreColor=ConsoleColor.Gray,ConsoleColor backColor=ConsoleColor.Black)
	{
		Put (x0,y0,Symbols.RD,foreColor,backColor);
		Put (x1,y0,Symbols.DL,foreColor,backColor);
		Put (x1,y1,Symbols.LU,foreColor,backColor);
		Put (x0,y1,Symbols.RU,foreColor,backColor);
		for (int x=x0+1;x<x1;x++)
		{
			Put (x,y0,Symbols.LR,foreColor,backColor);
			Put (x,y1,Symbols.LR,foreColor,backColor);
		}
		for (int y=y0+1;y<y1;y++)
		{
			Put (x0,y,Symbols.UD,foreColor,backColor);
			Put (x1,y,Symbols.UD,foreColor,backColor);
		}
	}
			
}