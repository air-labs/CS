using System;

public class S04
{
    //Метод с перегруженным количеством аргументов
    static void Print(ConsoleColor foreColor, params string[] lines)
    {
        Console.ForegroundColor = foreColor;
        foreach (var e in lines)
            Console.WriteLine(e);
        Console.WriteLine();
    }

    public static void MainX()
    {
        Print(ConsoleColor.Red);
        Print(ConsoleColor.Blue, "a", "b", "c");
        var array = new string[] { "x", "y", "z" };
        Print(ConsoleColor.Green, array);
    }
}
