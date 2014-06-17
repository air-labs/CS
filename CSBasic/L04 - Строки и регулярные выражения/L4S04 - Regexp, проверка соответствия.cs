using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;


class L4S04
{
    static void MainX()
    {
        var regex = new Regex("^[0-9]*$");
        Console.WriteLine(regex.Match("03436343").Success);
        Console.WriteLine(regex.Match("03436343").Success);
        Console.WriteLine(regex.Match("03436343").Success);

    }
}