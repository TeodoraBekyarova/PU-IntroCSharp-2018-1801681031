using System;

namespace _4thDigits
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number with 7 digits:");
            int number = int.Parse(Console.ReadLine());
            if (number < 1000000 || number > 9999999) ;
            {
                Console.WriteLine("The number you entered is not a 7 digits number!");
            }
            else
            {
                int forthDigit = number % 1000000 % 100000 % 10000 / 1000;
                Console.WriteLine($The 4th digith of { number} is { forthDigit});
        }
    }
}
