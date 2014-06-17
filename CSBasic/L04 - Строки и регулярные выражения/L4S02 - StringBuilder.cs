using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;


class L4S02
{
    static void ConcatWrong()
    {
        var res = "";
        for (int i = 0; i < 50000; i++)
            res += i.ToString() + ",";
        
    }

    static void ConcatRight()
    {
        var builder = new StringBuilder();
        for (int i = 0; i < 50000; i++)
            builder.Append(i.ToString() + ",");
        var res = builder.ToString();
    }

    public static void MainX()
    {
        var watch = Stopwatch.StartNew();
        ConcatWrong();
        Console.WriteLine(watch.ElapsedMilliseconds);

        watch = Stopwatch.StartNew();
        ConcatRight();
        Console.WriteLine(watch.ElapsedMilliseconds);

    }
}