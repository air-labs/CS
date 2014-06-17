using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;


class L4S05
{
    static void MainX()
    {
        var regex = new Regex("([0-9]+)");
        var match = regex.Match("ab 12 cd 345 ef 678");
        while (match.Success)
        {
            Console.WriteLine(match.Value);
            match = match.NextMatch();
        }
    }
}