using System;
using System.Diagnostics;
using System.Threading;
namespace S08
{
    public class Program
    {
       
        //В конкретно этом случае можно также использовать nullable
        public static ConsoleKey? WaitForKey(int timeInMilliseconds)
        {
            var watch=new Stopwatch();
            watch.Start();
            while (watch.ElapsedMilliseconds < timeInMilliseconds)
            {
                if (Console.KeyAvailable)
                {
                    watch.Stop();
                    return Console.ReadKey().Key;
                }
                Thread.Sleep(1);
            }
            watch.Stop();
            return null;
        }

        public static string WaitForString()
        {
            //читаем строку из файла или сетевого соединения, и возвращаем ее
            return null;
        }


        public static void MainX()
        {
            var keyWait = WaitForKey(1000);
            if (keyWait.HasValue) 
                Console.WriteLine("KEY PRESSED: " + keyWait.Value);
            else
                Console.WriteLine("KEY IS NOT PRESSED");
        }
    }
}
