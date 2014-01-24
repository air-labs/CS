using System;
namespace L2S02
{
    public class Statistics
    {
        private double totalCount;
        private double successCount;

        public void AccountCase(bool success)
        {
            totalCount++;
            if (success) successCount++;
        }

        public double GetTotalCount() { return totalCount; }

        public double GetSuccessCount() { return successCount; }

        public double GetSuccessPercentage() { return successCount / totalCount; }
    }

    public class Program
    {
        public static void MainX()
        {
            var stat = new Statistics();
            var rnd = new Random();
            for (int i = 0; i < 1000; i++)
                stat.AccountCase(rnd.Next(2) > 0);
            Console.WriteLine("Statistics: {0}/{1} = {2}%", stat.GetSuccessCount(), stat.GetTotalCount(), (double)stat.GetSuccessPercentage() * 100);
        }
    }
}
