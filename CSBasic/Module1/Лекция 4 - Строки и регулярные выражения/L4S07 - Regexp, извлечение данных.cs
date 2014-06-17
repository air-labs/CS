using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;


class L4S07
{
    

    static void MainX()
    {
        var regex = new Regex(@"(?<user>[\w\d\.]+)@gmail.com");
        var match = regex.Match("John Smith (john.smith@gmail.com) wants to sent mail to alice1990@gmail.com");
        while (match.Success)
        {
            Console.WriteLine(match.Groups[1]);
            match = match.NextMatch();
        }
    }
}