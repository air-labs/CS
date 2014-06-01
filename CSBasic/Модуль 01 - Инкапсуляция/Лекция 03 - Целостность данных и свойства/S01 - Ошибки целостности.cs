using System;
namespace S01
{

    public class Statistics
    {
        public int TotalCount;
        public int SuccessCount;
    }

    public class Program
    {

        public static void MainX()
        {
            var stat = new Statistics();
            var rnd = new Random();
            for (int i = 0; i < 1000; i++)
            {
                stat.TotalCount++;
                stat.SuccessCount += rnd.Next(2) > 0 ? 1 : 0;  
            }
            Console.WriteLine("Statistics: {0}/{1} = {2}%", stat.SuccessCount, stat.TotalCount, (double)stat.SuccessCount*100 / stat.TotalCount);
        }
    }
}