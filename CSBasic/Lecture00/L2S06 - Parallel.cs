using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

class L2S06
{
    public static void MainX()
    {
        var watch = Stopwatch.StartNew();
        for (int i = 0; i < 10; i++) DoWork(i);
        //Parallel.For(0, 10, DoWork);
        //Parallel.Invoke(() => DoWork(0), () => DoWork(1), () => DoWork(2));
        Console.WriteLine(watch.ElapsedMilliseconds);
        Console.ReadKey();
        
        
    }

    static void DoWork(int job)
    {
        double a = 0;
        for (int i=0;i<1000;i++)
        for (int j = 0; j < 1000000; j++)
            a /= 1.001;
        Console.WriteLine("Job {0} completed", job);
    }
}