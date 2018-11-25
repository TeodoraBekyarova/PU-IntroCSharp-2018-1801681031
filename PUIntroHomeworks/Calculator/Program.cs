using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string answer;

            do
            {
                Console.WriteLine("Do you want to make some calculations? yes/no");
                answer = Console.ReadLine();
                
                if (answer == "yes")
                {
                    double firstNumber = 0;
                    double secondNumber = 0;

                    bool firstInputIsNumber = false;
                    bool secondInputIsNumber = false;

                    while (!firstInputIsNumber)
                    {
                        Console.WriteLine("Enter first number:");
                        firstInputIsNumber = double.TryParse(Console.ReadLine(), out firstNumber);

                        if (!firstInputIsNumber)
                        {
                            Console.WriteLine("Enter a valid number!");
                        }
                    }

                    while (!secondInputIsNumber)
                    {
                        Console.WriteLine("Enter second number:");
                        secondInputIsNumber = double.TryParse(Console.ReadLine(), out secondNumber);

                        if (!secondInputIsNumber)
                        {
                            Console.WriteLine("Enter a valid number!");
                        }
                    }

                    Console.WriteLine("Enter an operation (+, -, * or /).");
                    char calcOperator = char.Parse(Console.ReadLine());
                    double result;

                    switch (calcOperator)
                    {
                        case '+':
                            double sum = firstNumber + secondNumber;
                            result = sum + sum * 0.1;
                            Console.WriteLine("The sum increased by 10% is: {0:F2}", result);
                            break;
                        case '-':
                            if (firstNumber > secondNumber)
                            {
                                result = firstNumber * firstNumber - secondNumber;
                            }
                            else
                            {
                                result = secondNumber * secondNumber - firstNumber;
                            }
                            Console.WriteLine("(MaxNumber * MaxNumber) - MinNumber is: {0:F2}", result);
                            break;
                        case '*':
                            result = firstNumber * Math.Sqrt(secondNumber);
                            Console.WriteLine("First Number * Sqrt(Second Number) is: {0:F2}", result);
                            break;
                        case '/':
                            if (secondNumber == 0)
                            {
                                Console.WriteLine("Division by 0 is forbidden!");
                            }
                            break;
                        
                        default:
                            Console.WriteLine("Incorrect operation!");
                            break;
                    }
                }
            } while (answer != "no");
            
            Environment.Exit(0);
        }
    }
}
