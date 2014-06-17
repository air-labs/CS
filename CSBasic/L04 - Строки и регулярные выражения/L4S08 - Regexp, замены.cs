using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;


class L4S08
{
    public static void MainX()
    {
        var LaTeX = @"
\chapter{Introduction to C#}

\section{Regular Expressions}

This chapter explains how to use {\it regular expressions} to process strings";


        LaTeX = new Regex(@"\\chapter{([^}]*)}").Replace(LaTeX, "<h1>$1</h1>");
        LaTeX = new Regex(@"\\section{([^}]*)}").Replace(LaTeX, "<h2>$1</h2>");
        LaTeX = new Regex(@"{\\it +([^}]*)}").Replace(LaTeX, "<it>$1</it>");
       
        Console.WriteLine(LaTeX);
    }
}