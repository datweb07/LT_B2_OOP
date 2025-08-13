namespace ConsoleApp3
{
    public class Vector
    {
        private Point A;
        private Point B;

        public Point PointA { get { return A; } set { A = new Point(value); } }
        public Point PointB { get { return B; } set { B = new Point(value); } }

        public Vector()
        {
            A = new Point();
            B = new Point();
        }

        public Vector(Point a, Point b)
        {
            this.A = new Point(a);
            this.B = new Point(b);
        }

        public Vector(Vector v)
        {
            this.A = new Point(v.A);
            this.B = new Point(v.B);
        }

        public static Point CalculatorVector(Point a, Point b)
        {
            return new Point(b.X - a.X, b.Y - a.Y);
        }

        public static double AngleBetweenVectors(Vector v1, Vector v2)
        {
            double tichVoHuong = (v1.PointB.X - v1.PointA.X) * (v2.PointB.X - v2.PointA.X) + (v1.PointB.Y - v1.PointA.Y) * (v2.PointB.Y - v2.PointA.Y);
            double magnitudeV1 = Math.Sqrt(Math.Pow(v1.PointB.X - v1.PointA.X, 2) + Math.Pow(v1.PointB.Y - v1.PointA.Y, 2));
            double magnitudeV2 = Math.Sqrt(Math.Pow(v2.PointB.X - v2.PointA.X, 2) + Math.Pow(v2.PointB.Y - v2.PointA.Y, 2));
            return Math.Acos(tichVoHuong / (magnitudeV1 * magnitudeV2)) * (180.0 / Math.PI);
        }
    }
}
