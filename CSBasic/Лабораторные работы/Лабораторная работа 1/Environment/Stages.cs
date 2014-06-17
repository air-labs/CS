using System.Collections.Generic;
using System;
using System.Text;
namespace Lab1
{
	public static class Stages
	{
		public static List<Map> stages=new List<Map>();
		
		static void AddMap(Map map)
		{
			map.Number=stages.Count;
			stages.Add (map);
		}
		
		public static void InitializeStages()
		{
			var rnd=new Random();
			Map map=null;
			
			map=new Map("Ширина этой карты - 30, высота - 15",

			            "                             !",
			            "                              ",
			            "                              ",
			            "                              ",
			            "                              ",
			            "                              ",
			            "                              ",
			            "                              ",
			            "                              ",
			            "                              ",
			            "                              ",
			            "                              ",
			            "                              ",
			            "                            E ",
			            "!                             ");
			AddMap(map);
			
			
			map=new Map("Ширина этой карты - 30, высота - 17",

			            "                             !",
			            "XXXXXXXXXXXXXXXXXXXXXXXXXXX! X",
			            "!                             ",
			            "X !XXXXXXXXXXXXXXXXXXXXXXXXX!X",
			            "                             !",
			            "X!XXXXXXXXXXXXXXXXXXXXXXXXX! X",
			            "!                             ",
			            "X !XXXXXXXXXXXXXXXXXXXXXXXXX!X",
			            "                             !",
			            "X!XXXXXXXXXXXXXXXXXXXXXXXXX! X",
			            "!                             ",
			            "X !XXXXXXXXXXXXXXXXXXXXXXXXX!X",
			            " E                            ");
			AddMap (map);
			
			map=new Map(
	        "Длины этажей 11,7,15,12,20,25,23. Используйте foreach",
			            "           !                  ",
			            "XXXXXXXXX! X                  ",
			            "   !       X                  ",
			            "   X !XXXX!XXXXXXXXX          ",
			            "   X               !          ",
			            "   X!XXXXXXXXXXXX! X          ",
			            "      !            X          ",
			            "      X !XXXXXXXXX!XXXXXXXXX  ",
			            "      X                    !  ",
			            " XXXXXX!XXXXXXXXXXXXXXXXX! X  ",
			            " !                         X  ",
			            " X !XXXXXXXXXXXXXXXXXXXXXX!X  ",
			            " X                       X    ",
			            " X!XXXXXXXXXXXXXXXXXXXXX X    ",
			            "                        EX    ");
			AddMap (map);
						
			map=new Map(
	        "Упершись в стену, поворачивайте всегда направо. Используйте while",
			            "                   XXXXXXXXXXX",
			            "XXXXXXXXXXX XXXXXX            ",
			            "XXXXXXXXXXX XXXXXX XXXXXXXXXX ",
			            "                 X X          ",
			            " XXX XXXXXXXXXXXXX XXXXXXXXXX ",
			            " XXX X                   XXXX ",
			            " XXX X XXXXXXXXXXX XXXXX XXXX ",
			            " X                          X ",
			            " X X X XXXXXXXXXXX XX XX XX X ",
			            " X X X             XX XX XX X ",
			            " X XXXXXXXXXXXXXXXXXXXXX XX X ",
			            " X                       XX X ",
			            " XXXXXXXXXXXXXXXXXXXXXXXXXX X ",
			            "    XXXXXE                  X ");
			AddMap (map);
			
			
			map=new Map(
				"Подберите ключ, посмотрите на него, и выберите нужную дверь",
				"                            X ",
				"                            X ",
				"                            C ",
				"                            X ",
				"                            X ",
				"                            GE",
				"                            X ",
				"                            X ",
				"                            S ",
				"                            X ",
				"                            X ");
			map.map[0,5]=(MapElements)(MapElements.GoldKey+rnd.Next (3));
			AddMap(map);
			
			map=new Map("Дойдите до указателя и прочитайте на нем координату Y прохода",
			    "                            X ",
				"                            X ",
				"                            X ",
				"                            X ",
				"                            X ",
				"T                           XE",
				"                            X ",
				"                            X ",
				"                            X ",
				"                            X ",
				"                            X ");
		    var y=rnd.Next (map.Height);
			map.map[map.Width-2,y]=  MapElements.Space;
			map.hints[0,5]=y.ToString ();
			AddMap (map);

            map=new Map("Злодеи хотят запутать вас, добавив фальшивых табличек вместо настоящих. На настоящей табличке написана координата Y прохода, на фальшивых - чушь. Найдите правильную табличку с помощью блока try-catch.",
                "                            X ",
                "T                           X ",
                "T                           X ",
                "T                           X ",
                "T                           X ",
                "T                           XE",
                "                            X ",
                "                            X ",
                "                            X ",
                "                            X ",
                "                            X ");
            y = rnd.Next(map.Height);
            map.map[map.Width - 2, y] = MapElements.Space;
            var right = rnd.Next(4)+1;
            for (int i = 0; i < 5; i++)
            {
                if (i == right)
                    map.hints[0, i + 1] = y.ToString();
                else
                {
                    char c = ' ';
                    while (true)
                    {
                        c = (char)rnd.Next(255);
                        if (char.IsLetter(c)) continue;
                        else break;
                    }
                    map.hints[0, i + 1] = c.ToString();
                }

            }
            AddMap(map);

            map = new Map("Злодеи зашифровали надпись на указатели, случайным образом включив в нее латинские буквы. Решите эту проблему с помощью регулярных выражений",
                "                            X ",
                "                            X ",
                "                            X ",
                "                            X ",
                "                            X ",
                "T                           XE",
                "                            X ",
                "                            X ",
                "                            X ",
                "                            X ",
                "                            X ");
            y = rnd.Next(map.Height);
            map.map[map.Width - 2, y] = MapElements.Space;

            var bld = new StringBuilder(y.ToString());
            for (int i = 0; i < 20; i++)
            {
                bld.Insert(rnd.Next(bld.Length+1), (char)('a' + rnd.Next(23)));
            }
            map.hints[0, 5] = bld.ToString();
            AddMap(map);
			            
		}


	}
}


/*
 
        static void Go(Direction dir, int cnt)
        {
            for (int i = 0; i < cnt; i++)
                Go(dir);
        }

        
        static void Level0()
        {
            for (int i=0;i<28;i++)
                Go(Direction.Right);
            for (int i=0;i<14;i++)
                Go(Direction.Down);			
        }
		
        static void Level1()
        {
            Go (Direction.Right);
            for (int i=0;i<4;i++)
            {
                for (int j=0;j<27;j++)
                    Go (Direction.Right);
                for (int j=0;j<2;j++)
                    Go (Direction.Down);
                for (int j=0;j<27;j++)
                    Go (Direction.Left);
                for (int j=0;j<2;j++)
                    Go (Direction.Down);
            }
        }
		
        static void Level2()
        {
            var len=new int[]{11,-7,15,-12,20,-25,23};
            foreach(var e in len)
            {
                for (int i=0;i<Math.Abs (e)-1;i++)
                    Go (e<0?Direction.Left:Direction.Right);
                for (int i=0;i<2;i++)
                    Go (Direction.Down);
            }
				
        }
		
        static void Level3()
        {
            var dir=new []{Direction.Right,Direction.Down,Direction.Left,Direction.Up};
            int pos=0;
            while(true)
            {
                Go (dir[pos]);
                if (HittedObject== MapElements.Wall)
                    pos=(pos+1)%4;
            }
        }
		
		
		
        static void Level4()
        {
            Go (Direction.Down,5);
			
            if (HittedObject== MapElements.CopperKey)
            {
                Go (Direction.Up,3);
                Go (Direction.Right,30);
                Go (Direction.Down,3);
            }
            else if (HittedObject== MapElements.SilverKey)
            {
                Go (Direction.Down,3);
                Go (Direction.Right,30);
                Go (Direction.Up,3);
            }

        else Go (Direction.Right,30);
        }
			

		
        static void Level5()
        {
            Go(Direction.Down, 5);
            var y = int.Parse(Hint);
            Go(Direction.Up, 5);
            Go(Direction.Down, y);
            Go(Direction.Right, 30);
            Go(Direction.Up, y);
            Go(Direction.Down, 30);

        }

        static void Level6()
        {
            var y = -1;
            for (int i = 0; i < 5; i++)
            {
                Go(Direction.Down);
                try
                {
                    y = int.Parse(Hint);
                    break;
                }
                catch
                { }
            }
            Go(Direction.Up, 5);
            Go(Direction.Down, y);
            Go(Direction.Right, 30);
            Go(Direction.Up, y);
            Go(Direction.Down, 30);
        }

        static void Level7()
        {
            Go(Direction.Down, 5);
            var nhint = new Regex("[a-z]").Replace(Hint, "");
            var y = int.Parse(nhint);
            Go(Direction.Up, 5);
            Go(Direction.Down, y);
            Go(Direction.Right, 30);
            Go(Direction.Up, y);
            Go(Direction.Down, 30);

        }

 
		public static void Main (string[] args)
		{
			var game=GetCurrentGame();
            switch (game)
            {
                case 0: Level0(); break;
                case 1: Level1(); break;
                case 2: Level2(); break;
                case 3: Level3(); break;
                case 4: Level4(); break;
                case 5: Level5(); break;
                case 6: Level6(); break;
                case 7: Level7(); break;
            }
            Console.ReadKey();
			
		}
 
*/
