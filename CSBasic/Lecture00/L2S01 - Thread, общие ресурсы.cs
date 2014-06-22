using System;
using System.Threading;
class L2S01
{
    static void Clock()
    {
        while (true)
        {
            var x = Console.CursorLeft;
            var y = Console.CursorTop;
            var fore = Console.ForegroundColor;
            var back = Console.BackgroundColor;
            Console.CursorTop = 0;
            Console.CursorLeft = 60;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.Write("{0:hh:mm:ss}", DateTime.Now);
            Console.CursorLeft =x;
            Console.CursorTop = y;
            Console.ForegroundColor = fore;
            Console.BackgroundColor = back;
            Thread.Sleep(1000);

        }
    }

    static void Main()
    {
        Thread thread = new Thread(Clock);
        thread.Start();

        while (true)
        {
            Console.CursorTop = 1;
            Console.CursorLeft = 0;
            Console.Write("Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.");
            Thread.Sleep(10);
        }
    }
}
