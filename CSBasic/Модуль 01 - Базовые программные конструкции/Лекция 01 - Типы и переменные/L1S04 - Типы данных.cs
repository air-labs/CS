using System;

public class L1S04
{
    public static void MainX()
    {
        int number = 10;
        long longNumber = 1000000000;
        double floatingPoint = 12.34;
        bool boolean = true; //или false

        longNumber = number;
        // number=longNumber; // ошибка приведения типа
        number = (int)longNumber;

        //number=floatingPoint; //ошибка приведения типа
        number = (int)floatingPoint;
        floatingPoint = number;

        string str = "Hello, world!";
        str = number.ToString();
        number = int.Parse(str);
        floatingPoint = double.Parse(str);

        Console.WriteLine(str.Length);
        Console.WriteLine(int.MaxValue);

        var newNumber = number + 12;
        var newFloat = 12.45;
    }
}
