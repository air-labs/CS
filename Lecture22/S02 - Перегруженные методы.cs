using System;

public class S02
{
    //Если есть несколько методов с одинаковыми именами, но разной сигнатурой, они называются перегруженными
    public static void Print(string text, ConsoleColor foreColor, ConsoleColor backColor)
    {
        Console.ForegroundColor = foreColor;
        Console.BackgroundColor = backColor;
        Console.WriteLine(text);
    }

    public static void Print(string text, ConsoleColor foreColor)
    {
        Print(text, foreColor, ConsoleColor.Black);
    }

    public static void Print(string text)
    {
        Print(text, ConsoleColor.Gray, ConsoleColor.Black);
    }

    public static void Main()
    {
        Print("some text here", ConsoleColor.Yellow, ConsoleColor.Blue);
        Print("some text here", ConsoleColor.Yellow);
        Print("some text here");
    }


}