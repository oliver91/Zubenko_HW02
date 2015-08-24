using System;

namespace Classes_Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(1, 3, "p1");
            Point p2 = new Point(3, 4, "p2");
            Point p3 = new Point(4, 2, "p3");
            Point p4 = new Point(3, 1, "p4");
            Point p5 = new Point(1, 1, "p5");
            Console.WriteLine("with 3 points: ");
            Figure figr1 = new Figure(p1, p2, p3);
            figr1.PerimeterCalculator();
            Console.WriteLine("with 4 points: ");
            Figure figr2 = new Figure(p1, p2, p3, p4);
            figr2.PerimeterCalculator();
            Console.WriteLine("with 5 points: ");
            Figure figr3 = new Figure(p1, p2, p3, p4, p5);
            figr3.PerimeterCalculator();
            Console.ReadKey();
        }
    }

    internal class Point
    {
        private int x, y;
        private string name;

        public Point(int x, int y, string name)
        {
            this.x = x;
            this.y = y;
            this.name = name;
        }

        public int X {
            get { return x; }
        }

        public int Y
        {
            get { return y; }
        }

        public string Name
        {
            get { return name; }
        }
    }

    internal class Figure
    {
        private Point p1, p2, p3, p4, p5;

        public Figure(Point p1, Point p2, Point p3)
        {
            this.p1 = p1;
            this.p2 = p2;
            this.p3 = p3;
            p4 = null;
            p5 = null;
        }
        public Figure(Point p1, Point p2, Point p3, Point p4)
        {
            this.p1 = p1;
            this.p2 = p2;
            this.p3 = p3;
            this.p4 = p4;
            p5 = null;
        }
        public Figure(Point p1, Point p2, Point p3, Point p4, Point p5)
        {
            this.p1 = p1;
            this.p2 = p2;
            this.p3 = p3;
            this.p4 = p4;
            this.p5 = p5;
        }

        public double LengthSide(Point A, Point B)
        {
            return Math.Sqrt(Math.Pow((B.X - A.X), 2) + Math.Pow((B.Y - A.Y), 2));
        }

        public void PerimeterCalculator()
        {
            double perimeter;
            if ((p4 == null) & (p5 == null))
            {
                perimeter = LengthSide(p1, p2) + LengthSide(p2, p3) + LengthSide(p3, p1);
            }
            else if ((p4 != null) & (p5 == null))
            {
                perimeter = LengthSide(p1, p2) + LengthSide(p2, p3) + LengthSide(p3, p4) + LengthSide(p4, p1);
            }
            else
            {
                perimeter = LengthSide(p1, p2) + LengthSide(p2, p3) + LengthSide(p3, p4) + LengthSide(p4, p5) + LengthSide(p5, p1);
            }
            Console.WriteLine("Perimeter: {0}", perimeter);
        }
    }
}
