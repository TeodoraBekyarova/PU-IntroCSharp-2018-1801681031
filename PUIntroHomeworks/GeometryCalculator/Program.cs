using System;

namespace GeometryCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose option (triangle,square or radians):");
            string option = Console.ReadLine();

            
            switch (option)
            {
                case "triangle":
                    Console.Write("Enter one side:");
                    double a = double.Parse(Console.ReadLine());
                    Console.Write("Enter the height to that side:");
                    double h = double.Parse(Console.ReadLine());

                    Console.WriteLine("The area of this triangle is: " + TriangleArea(a, h));
                    break;
                case "square":
                    Console.Write("Enter a side:");
                    double squareSide = double.Parse(Console.ReadLine());

                    Console.WriteLine("The area of this square is: " + SquareArea(squareSide));
                    break;
                case "radians":
                    Console.Write("Enter an angle in degrees:");
                    double angleDegrees = double.Parse(Console.ReadLine());

                    Console.WriteLine($"{angleDegrees} degrees in radians is: " + AngleInRadians(angleDegrees));
                    break;
                default:
                    Console.WriteLine("Incorrect option.");
                    break;
            }
        }

        
        static double TriangleArea(double tSide, double tHeight)
        {
            double triangleArea = (tSide * tHeight) / 2;

            return triangleArea;
        }

        
        static double SquareArea(double aSquare)
        {
            double sSquare = aSquare * aSquare;

            return sSquare;
        }

        
        static double AngleInRadians(double angleDeg)
        {
            double angleInRadians = Math.PI / 180 * angleDeg;

            return angleInRadians;
        }
    }
}
