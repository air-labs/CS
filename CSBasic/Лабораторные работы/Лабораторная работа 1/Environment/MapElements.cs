using System;

namespace Lab1
{
	public enum MapElements
	{
		Space=0,
		Wall=1,
		GoldKey=2,
		SilverKey=3,
		CopperKey=4,
		GoldDoor=5,
		SilverDoor=6,
		CopperDoor=7,
		Hint=8,
		Exit=9,
		Pike=10
	}
	
	class MapElementDetails
	{
		public MapElements Element { get; set; }
		public char InputChar { get; set; }
		public char OutputChar { get; set; }
		public ConsoleColor Color { get; set; }
	}
}

