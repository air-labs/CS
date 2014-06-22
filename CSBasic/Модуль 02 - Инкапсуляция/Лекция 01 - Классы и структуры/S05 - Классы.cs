using System;

namespace S05
{
    public class Point
    {
        public int X;
        public int Y;
    }

    public class Program
    {
        static Point globalPoint;

        public static void MainX()
        {
            Point localPoint = new Point();
            localPoint.X = 5;
            localPoint.Y = 10;

            globalPoint = new Point();
            globalPoint.X = 5;
            globalPoint.Y = 10;

        }
    }
}