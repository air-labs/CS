using System;
namespace L3S09
{

    class Program
    {
        public static void MainX()
        {
            var rnd = new Random();

            Console.WriteLine(rnd.NextDouble());

            //Иногда хочется добавить метод, которого в классе нет
            Console.WriteLine(rnd.NextDouble(-1,1));

        }
    }



    public static class RandomExtensions
    {
        public static double NextDouble(this Random rnd, double min, double max)
        {
            return min + rnd.NextDouble() * (max - min);
        }
    }



}
