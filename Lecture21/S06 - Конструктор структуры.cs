using System;

namespace S06
{
    public struct Point
    {
        public int X;
        public int Y;

        // public Point() { } // конструктор по умолчанию есть всегда, и переопределять его нельзя

        public Point(int x, int y)
        {
            X = x; //обязательно инициализировать все поля!
            Y = y;
        }
    }

    public class Program
    {
        public static void MainX()
        {
            Point point; 
            point.X = 5;
            point.Y = 10;

            point = new Point(50, 100);
        }
    }
}