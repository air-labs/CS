using System;

namespace S06
{
    public struct Point
    {
        public int X;
        public int Y;
    }

    public class Program
    {

        static Point globalPoint;

        public static void MainX()
        {
            Point localPoint;
            localPoint.X = 5;
            localPoint.Y = 10;
            
            globalPoint.X = 5;
            globalPoint.Y = 10;

        }
    }
}