using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


class L4S03
{
    static void MainX()
    {
   
        
        var a = 13;
        var b = 14.3456789;
        var d = DateTime.Now;

        Console.WriteLine(a.ToString() + " " + b.ToString());
        Console.WriteLine(string.Format("{0} {1}", a, b));
        Console.WriteLine("{0} {1}", a, b);

        Console.WriteLine("{0:hh-mm}", d);
        Console.WriteLine("{0:0.000} {1:0.0000}", 1.23456, 1.23456);
        Console.WriteLine("{0:0.000} {1:0.###}", 1.2, 1.2);
        Console.WriteLine("{0,10}|\n{1,10}|", 12345, 123);
        Console.WriteLine("{0,10:0.00}|\n{1,10:0.000}|", 1.45, 21.345);
        Console.WriteLine("{0,10:D3}", 12);
    }
}