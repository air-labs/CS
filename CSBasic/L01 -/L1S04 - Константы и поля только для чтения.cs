using System;

public class L1S04
{
    readonly DateTime date = DateTime.Now;
    const double G = 9.780327;
    // const DateTime newDate=DateTime.Now; //константе можно присвоить только значение

    public static void MainX()
    {
        var instance = new L1S04();
        //instance.date=instance.date.AddDays (10); //нельзя изменить значение readonly переменной
        //G = 10; //нельзя изменить значение константы
    }
}
