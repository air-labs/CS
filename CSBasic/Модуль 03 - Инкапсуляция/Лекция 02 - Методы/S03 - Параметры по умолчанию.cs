using System;

public class S03
{
    //В качестве альтернативы перегрузке можно использовать параметры по умолчанию
    public static void Print(string text,
        ConsoleColor foreColor = ConsoleColor.Gray,
        ConsoleColor backColor = ConsoleColor.Black)
    {
        Console.ForegroundColor = foreColor;
        Console.BackgroundColor = backColor;
        Console.WriteLine(text);
    }

    public static void MainX()
    {
        Print("some text here", ConsoleColor.Yellow, ConsoleColor.Blue);
        Print("some text here", ConsoleColor.Yellow);
        Print("some text here");
        Print("some text here", backColor: ConsoleColor.Blue);
    }


}