using System.Collections.Generic;
using System;
class L1S04
{
    public static void MainX()
    {
        var text = "A AB B BA A AB A AB B".Split(' ');
        var dict = new Dictionary<string, int>();
        foreach (var e in text)
            if (!dict.ContainsKey(e)) dict[e] = 1;
            else dict[e]++;

        foreach (var e in dict)
        {
            Console.WriteLine("{0}\t{1}", e.Key, e.Value);
        }
    }
}
