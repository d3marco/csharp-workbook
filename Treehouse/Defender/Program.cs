using System;

namespace Defender
{
    class Game
    {
        static void Main(string[] args)
        {
            Map map = new Map(8, 5);

            Point point = new Point(4,2);

            Console.WriteLine(point.DistanceTo(5,5));
            
        }
    }

    class Tower
    {

    }
    class Invader
    {

    }
    class Map
    {
        public readonly int Width;
        public readonly int Height;

        public Map(int width, int height)
        {
            Width = width;
            Height = height;
        }
        public bool OnMap(Point point)
        {
            return point.X >= 0 &&
             point.X <= 8 && point.Y >= 0
             && point.Y <= 5;

        }
    }
    class Path
    {

    }
    class Point
    {
        public readonly int X;
        public readonly int Y;
        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }
        public int DistanceTo(int x, int y)
        {
        //    int xDiff = X - x;
        //    int yDiff = Y - y; 

        //    int xDiffSquared = xDiff * xDiff;
        //    int yDiffSquared = yDiff * yDiff;

        //   return (int)Math.Sqrt(xDiffSquared + yDiffSquared);
          return (int)Math.Sqrt(Math.Pow(X-x,2) + Math.Pow(Y-y,2));



        }
    }
}
