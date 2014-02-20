using System;
using System.Collections.Generic;
class L2S05
{
    public static void Sort<T>(List<T> list)
        where T : IComparable
    {
        for (int i = 0; i < list.Count; i++)
            for (int j = 0; j < list.Count; j++)
                if (list[i].CompareTo(list[j]) < 0)
                {
                    var temp = list[i];
                    list[i] = list[j];
                    list[j] = temp;
                }
    }

    public static void Main()
    {
        var list = new List<int> { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 };
        Sort(list);
        foreach (var e in list)
            Console.Write("{0} ", e);
    }
}
//! Генерик-метод
