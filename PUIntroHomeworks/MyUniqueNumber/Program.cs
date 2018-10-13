using System;

namespace MyUniqueNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How old are you?");
            int myAge = 19;
            Console.WriteLine("19");
            Console.WriteLine("Enter the last 4 digits of your faculty number here:");
            int last4Digits = 1031;
            Console.WriteLine("1031");

            double result = myUniqueNumber(ageAfter10Years(myAge), last4Digits);

            Console.WriteLine("After 10 years you will be " + ageAfter10Years(age) + " years old. " +
                "And your unique number is: " + result);
        }
            private static int AgeAfter10Years(int myAge);

        {
            int ageAfter10Years = myAge + 10;

            return ageAfter10Years;
        }
            static double myUniqueNumber(int ageAfter10Years, int last4DigitsOfFackNumber);
        {
            double myUniqueNumber = (ageAfter10Years * last4DigitsOfFackNumber) / Math.PI;
            return myUniqueNumber;

        }
    }
}
