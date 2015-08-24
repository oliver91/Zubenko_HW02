using System;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter rectangle's side1: ");
            double side1 = Double.Parse(Console.ReadLine());
            Console.Write("\nEnter rectangle's side2: ");
            double side2 = Double.Parse(Console.ReadLine());
            Console.WriteLine();
            Rectangle rect = new Rectangle(side1, side2);
            Console.Write("Area: {0}", rect.Area);
            Console.WriteLine("\nPerimeter: {0}", rect.Perimeter);
            Console.ReadKey();
        }
    }

    internal class Rectangle
    {
        private double side1, side2;

        public Rectangle(double side1, double side2)
        {
            this.side1 = side1;
            this.side2 = side2;
        }

        public double AreaCalculator()
        {
            return side1 * side2;
        }

        public double PerimeterCalculator()
        {
            return (side1 * 2) + (side2 * 2);
        }

        public double Area
        {
            get
            {
                return AreaCalculator();
            }
        }

        public double Perimeter
        {
            get { return PerimeterCalculator(); }
        }
    }
}
