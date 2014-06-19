using System;

public class L1S02
{
    static string globalVariable = "Static";

    static void MainX()
    {
        Console.WriteLine("We are in Main method");
        string localVariable = "Local";
        if (localVariable.Length > 3)
        {
            string temporaryVariable = "Temporary";
            Console.WriteLine(globalVariable);
            Console.WriteLine(localVariable);
            Console.WriteLine(temporaryVariable);
        }
        else
        {
            Console.WriteLine(globalVariable);
            Console.WriteLine(localVariable);
            //Console.WriteLine (temporaryVariable); //нет доступа, т.к. переменная определена в другом блоке
        }
        StaticMethod();
    }

    static void StaticMethod()
    {
        Console.WriteLine("We are in StaticMethod");
        Console.WriteLine(globalVariable);
        //Console.WriteLine(localVariable); //эта переменная - локальная для MainX и не видна здесь
    }

}