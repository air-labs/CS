using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class L4S01
{
    public static void Main()
    {
        var res = "Some text, \"text in quotes\"\nNew line here\n\tTabulation\n\\ Backslash";
        Console.WriteLine(res);
        res = @"
Some text, ""text in quotes""
New line here
    Tabulation
\ Backslash";
        Console.WriteLine(res);

    }

}