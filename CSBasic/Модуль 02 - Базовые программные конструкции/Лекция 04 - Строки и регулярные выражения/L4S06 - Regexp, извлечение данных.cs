using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;


class L4S06
{
    static void ProcessEmail(string str)
    {
        var regex = new Regex(@"(?<user>[a-zA-Z]+)@(?<domain>\w+.\w+)");
        Console.WriteLine(str);
        var match=regex.Match(str);
        Console.WriteLine("This is {0}e-mail", match.Success ? "" : "NOT ");
        if (!match.Success) return;
        Console.WriteLine("user:   {0}", match.Groups[1].Value);
        Console.WriteLine("domain: {0}", match.Groups[2].Value);
        Console.WriteLine("\n\n");
    }

    static void MainX()
    {
        ProcessEmail("ivanov@yahoo.com");
        ProcessEmail("hacker tries to break-in");
    }
}