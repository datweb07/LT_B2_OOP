using System.Runtime.CompilerServices;

namespace ConsoleApp3
{
    public class Point
    {
        private float x;
        private float y;

        public float X { get { return x; } set { x = value; } }
        public float Y { get { return y; } set { y = value; } }

        public Point()
        {
            x = 0;
            y = 0;
        }

        public Point(float x, float y)
        {
            this.x = x;
            this.y = y;
        }

        public Point(Point p)
        {
            this.x = p.x;
            this.y = p.y;
        }

        public static double Distance(Point a, Point b)
        {
            return Math.Sqrt(Math.Pow(b.X - a.X, 2) + Math.Pow(b.Y - a.Y, 2));
        }

        public string Position()
        {
            if (X > 0 && Y > 0)
                return "Góc phần tư I";
            else if (X < 0 && Y > 0)
                return "Góc phần tư II";
            else if (X < 0 && Y < 0)
                return "Góc phần tư III";
            else if (X > 0 && Y < 0)
                return "Góc phần tư IV";
            else if (X == 0 && Y != 0)
                return "Trục tung";
            else if (Y == 0 && X != 0)
                return "Trục hoành";
            else
                return "Gốc tọa độ";
        }
    }
}
