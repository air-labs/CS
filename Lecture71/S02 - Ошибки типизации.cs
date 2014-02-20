using System.Collections;
using System;
class L1S02
{
    public static void MainX()
    {
        var intList = new ArrayList();
        intList.Add("Smith");
        int sum = 0;
        //foreach (var e in list) sum += e; //ошибка компиляции: в list лежат object, а не int
        foreach (int e in intList) sum += e; //выбрасывает исключение: третий элемент не является int
        Console.WriteLine(sum);

    }
}

//!Ошибки типа в нетипизированных коллекциях