using System;

namespace CircleArea
{
    class Program
    {
        static Random rand = new Random();

        static void Main(string[] args)
        {
           
                const double pi = Math.PI;                
                double circleRadius = rand.Next(33, 188); 

                
                double circleArea = pi * circleRadius * circleRadius;

                
                Console.WriteLine("The circle's random height is: " + circleRadius);
                
                Console.WriteLine("The circle's area is: {0:F2}", circleArea);
        }
    }
}
