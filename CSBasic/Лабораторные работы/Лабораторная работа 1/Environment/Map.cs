using System;
using System.Collections.Generic;
using System.Linq;
namespace Lab1
{
	
	
	
	public class Map
	{
		static List<MapElementDetails> table=new List<MapElementDetails>();
		static void Add(MapElements element, char inputChar, char outputChar, ConsoleColor color)
		{
			table.Add(new MapElementDetails
			         { Color=color, Element=element, InputChar=inputChar, OutputChar=outputChar });
		}
		static Map()
		{
			Add(MapElements.CopperDoor,'C',Symbols.Bar1,ConsoleColor.DarkYellow);
			Add(MapElements.CopperKey,'c',Symbols.dL,ConsoleColor.DarkYellow);
			Add(MapElements.SilverDoor,'S',Symbols.Bar1,ConsoleColor.Cyan);
			Add(MapElements.SilverKey,'s',Symbols.dL,ConsoleColor.Cyan);
			Add(MapElements.GoldDoor,'G',Symbols.Bar1,ConsoleColor.Yellow);
			Add(MapElements.GoldKey,'g',Symbols.dL,ConsoleColor.Yellow);
			Add(MapElements.Space,' ',' ',ConsoleColor.Black);
			Add(MapElements.Wall,'X',Symbols.Bar0,ConsoleColor.DarkGreen);
			Add(MapElements.Hint,'T','T',ConsoleColor.Red);
			Add(MapElements.Exit,'E',Symbols.Diamonds,ConsoleColor.Blue);
			Add (MapElements.Pike,'!',Symbols.Spades,ConsoleColor.Red);
		}
			 
		public int Number { get; set; }
		public readonly string Description;
		public readonly MapElements[,] map;
        public readonly string[,] hints;
		public readonly int Width;
		public readonly int Height;
		
		int descEnd=-1;
	
		
		public Map(string Description, params string[] imap)
		{
			this.Description=Description;
			this.Width=imap[0].Length;
			this.Height=imap.Length;
			map=new MapElements[Width,Height];
            hints = new string[Width, Height];
			for (int x=0;x<Width;x++)
				for (int y=0;y<Height;y++)
					map[x,y]=table.Where(z=>z.InputChar==imap[y][x]).FirstOrDefault ().Element;
		}
		
		public void Restore(int x, int y)
		{
			var symb=table.Where (z=>z.Element==map[x,y]).FirstOrDefault ().OutputChar;
				var color=table.Where (z=>z.Element==map[x,y]).FirstOrDefault ().Color;
				SuperConsole.Put (x+1,y+1,symb,color);
		}
			 
		public void PlacePlayer(int x, int y)
		{
			SuperConsole.Put (x+1,y+1,Symbols.WhiteFace,ConsoleColor.White);
		}
		
		public void ToSafePosition()
		{
			Console.CursorTop=descEnd;		
			Console.CursorLeft=0;
			
		}
			 
		
		public void Print()
		{
			SuperConsole.DoubleFrame (0,0,Width+1,Height+1,ConsoleColor.White);	
			for(int x=0;x<Width;x++)
				for (int y=0;y<Height;y++)
					Restore (x,y);
			
			SuperConsole.Print (0,Height+2,Description);
			descEnd=Console.CursorTop+1;
		}
		
	}
}
