using System;
using System.Diagnostics;
using System.Threading;
namespace S06
{
    //out-параметры - это дурной тон.
    //Их можно избежать с помощью структуры
    public class KeyWaitInfo
    {
        public bool IsPressed;
        public ConsoleKey Key;
    }

    public class Program
    {
        public static KeyWaitInfo WaitForKey(int timeInMilliseconds)
        {
            var watch=new Stopwatch();
            watch.Start();
            while (watch.ElapsedMilliseconds < timeInMilliseconds)
            {
                if (Console.KeyAvailable)
                {
                    watch.Stop();
                    return new KeyWaitInfo { IsPressed = true, Key = ConsoleKey.A };
                }
                Thread.Sleep(1);
            }
            watch.Stop();
            return new KeyWaitInfo { IsPressed = false };
        }


        public static void MainX()
        {
            var keyWait = WaitForKey(1000);
            if (keyWait.IsPressed)
                Console.WriteLine("KEY PRESSED: " + keyWait.Key);
            else
                Console.WriteLine("KEY IS NOT PRESSED");
        }
    }
}
