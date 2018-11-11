using System;

namespace GetMaxx
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 3 numbers and i will tell you which one is the biggest.");
            Console.WriteLine("Enter first number: ");
            int firstNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number: ");
            int secondNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter third number: ");
            int thirdNumber = int.Parse(Console.ReadLine());

           
            Console.WriteLine("The biggest number is: " + GetMax(firstNumber, secondNumber, thirdNumber));
        }

       
        static int GetMax(int num1, int num2, int num3)
        {
            
            if (num1 > num2 && num1 > num3)
            {
                return num1;
            }
            else if (num2 > num1 && num2 > num3)
            {
                return num2;
            }
            else return num3;
        }
    }
}
