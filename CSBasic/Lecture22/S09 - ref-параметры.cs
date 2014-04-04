using System;

class S09
{
    public static void WrongUpdateInt(int argument)
    {
        argument++;        
    }

    public static void UpdateInt(ref int argument)
    {
        argument++;
    }

    static void WrongUpdateString(string str)
    {
        str += "a";
    }


    static void UpdateString(ref string str)
    {
        str += "a";
    }


    public static void MainX()
    {
        int arg = 1;
        Console.WriteLine(arg);

        WrongUpdateInt(arg); //это бессмысленно, изменения не произойдет
        Console.WriteLine(arg);

        UpdateInt(ref arg);
        Console.WriteLine(arg);

        var str = "bc";
        Console.WriteLine(str);

        WrongUpdateString(str);
        Console.WriteLine(str);
      
        UpdateString(ref str);
        Console.WriteLine(str);
    }
}
