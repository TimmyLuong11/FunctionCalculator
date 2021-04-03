using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            const string develperName = "Timmy", className = "MIS3013", date = "April 3, 2021";
            DeveloperInformation(develperName, className, date);
            double num1, num2, num3, total;
            string answer = "";
            Console.SetWindowSize(130, 30);

            Console.WriteLine("This program is a calculator");
            Console.WriteLine("Please enter the first value:");
            answer = Console.ReadLine();
            num1 = DataValidation(answer);
            Console.WriteLine("Pleaes enter in the second value:");
            answer = Console.ReadLine();
            num2 = DataValidation(answer);
            Console.WriteLine("Which operation would you like to perform on the two values? Add, Subtract, Multiply, Divide");
            answer = Console.ReadLine().ToLower();
            total = Operation(answer, num1, num2);
            Console.WriteLine($"The total was {total}.");
            do
            {
                if (answer[0] == 'n')
                {
                    Console.WriteLine("Please enter the first value:");
                    answer = Console.ReadLine();
                    num1 = DataValidation(answer);
                    Console.WriteLine("Pleaes enter in the second value:");
                    answer = Console.ReadLine();
                    num2 = DataValidation(answer);
                    Console.WriteLine("Which operation would you like to perform on the two values? Add, Subtract, Multiply, Divide");
                    answer = Console.ReadLine().ToLower(); ;
                    total = Operation(answer, num1, num2);
                    Console.WriteLine($"The total was {total}.");
                }
                else if (answer[0] == 'p')
                {
                    num1 = total;
                    Console.WriteLine("Pleaes enter in the next value:");
                    answer = Console.ReadLine();
                    num3 = DataValidation(answer);
                    Console.WriteLine("Which operation would you like to perform on the two values? Add, Subtract, Multiply, Divide");
                    answer = Console.ReadLine().ToLower();
                    total = Operation(answer, num1, num3);
                    Console.WriteLine($"The total was {total}.");
                }
                Console.WriteLine("\nWould you like to do a new calculation, or use the result of the pervious calculation or type 'quit' to quit the program.");
                Console.WriteLine("Type 'new' for new calculation or type 'previous' for previous calculation:");
                answer = Console.ReadLine().ToLower();
            } while (answer[0] != 'q');

            Console.WriteLine("Thank you for using the calculator program! Have a great day!");
        }
        static double Operation(string answer, double num1, double num2)
        {
            double sum = 0;
            if (answer[0] == 'a')
            {
                sum = Add(num1, num2);
                
            }
            else if (answer[0] == 's')
            {
                sum = Subtract(num1, num2);

            }
            else if (answer[0] == 'm')
            {
                sum = Multiply(num1, num2);

            }
            else if (answer[0] == 'd')
            {
                sum = Divide(num1, num2);

            }
            else
            {
                Console.WriteLine("You did not enter a valid operation. Please try agian!");
            }
            return sum;
        }
        static double DataValidation(string answer)
        {
            double number;
            while (double.TryParse(answer, out number)==false)
            {
                Console.WriteLine("You did not enter in a number. Please try again!");
                answer = Console.ReadLine();
            }
            return number;
        }

        static double Add(double val1, double val2)
        {
            return val1 + val2;
        }
        static double Subtract(double val1, double val2)
        {
            return val1 - val2;
        }
        static double Multiply(double val1, double val2)
        {
            return val1 * val2;
        }
        static double Divide(double val1, double val2)
        {
            return val1 / val2;
        }
        static void DeveloperInformation(string developerName, string className, string date)
        {
            Console.WriteLine($"{developerName} wrote this program for {className} on {date}.\n");
        }
    }
}
