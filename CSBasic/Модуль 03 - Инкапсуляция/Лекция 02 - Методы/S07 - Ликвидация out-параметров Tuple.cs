using System;
using System.Diagnostics;
using System.Threading;
namespace S07
{
    public class Program
    {
       
        //Можно использовать генерик Tuple, но им лучше не злоупотреблять
        public static Tuple<bool,ConsoleKey> WaitForKey(int timeInMilliseconds)
        {
            var watch=new Stopwatch();
            watch.Start();
            while (watch.ElapsedMilliseconds < timeInMilliseconds)
            {
                if (Console.KeyAvailable)
                {
                    watch.Stop();
                    return Tuple.Create(true,ConsoleKey.A);
                }
                Thread.Sleep(1);
            }
            watch.Stop();
            return new Tuple<bool, ConsoleKey>(false, ConsoleKey.A);
        }


        public static void MainX()
        {
            var keyWait = WaitForKey(1000);
            if (keyWait.Item1) //Вот в этом месте неудобно - что означает Item1?
                Console.WriteLine("KEY PRESSED: " + keyWait.Item2);
            else
                Console.WriteLine("KEY IS NOT PRESSED");
        }
    }
}
