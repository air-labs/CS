using System.Collections.Generic;
using System;

class L1S03
{
    public static void MainX()
    {
        var intList = new List<int>();
        intList.Add(10);
        intList.Add(30);
        //intList.Add("Smith"); //ошибка компиляции: Ivanov не является int

        int sum = 0;
        foreach (var e in intList)
            sum += e;

        Console.WriteLine(sum);

    }
}
//!Генерик коллекции