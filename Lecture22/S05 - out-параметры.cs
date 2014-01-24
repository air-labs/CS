using System;
using System.Diagnostics;
using System.Threading;
namespace S05
{
    public class Program
    {
        //Как заставить метод возвращать два значения?
        //Например, предложить пользователю нажать кнопку в течение какого-то времени
        public static bool WaitForKey(out ConsoleKey value, int timeInMilliseconds)
        {

            var watch=new Stopwatch();
            watch.Start();
            while (watch.ElapsedMilliseconds < timeInMilliseconds)
            {
                if (Console.KeyAvailable)
                {
                    value = Console.ReadKey().Key;
                    watch.Stop();
                    return true;
                }
                Thread.Sleep(1);
            }
            watch.Stop();
            value = ConsoleKey.A; //нельзя не задать. Если закомментировать, будет ошибка
            return false;
        }


        public static void MainX()
        {
            ConsoleKey key;
            if (WaitForKey(out key, 1000))
                Console.WriteLine("KEY PRESSED: " + key.ToString());
            else
                Console.WriteLine("KEY IS NOT PRESSED");
        }
    }
}
