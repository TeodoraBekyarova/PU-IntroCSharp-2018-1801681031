using System;

namespace AverageNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            int evenNumbersCount = 0;
            double evenNumbersSum = 0;
            bool inputIsNumber;

            Console.WriteLine("Enter some numbers. When you're done, enter 0.");
            
            do
            {
                Console.WriteLine("Enter a number: ");
                inputIsNumber = int.TryParse(Console.ReadLine(), out number);

                
                if ((number >= 1 && number <= 255) && (number % 2 == 0))
                {
                    evenNumbersSum += number;
                    evenNumbersCount++;
                }
            } while (number != 0 || !inputIsNumber);

            
            if (evenNumbersCount == 0)
            {
                Console.WriteLine("There aren't any even numbers between 1 and 255.");
            }
            else
            {
                double evenNumbersAverage = evenNumbersSum / evenNumbersCount;
                Console.WriteLine("The average of the even numbers between 1 and 255 is: " + evenNumbersAverage);
            }
        }
    }
}
