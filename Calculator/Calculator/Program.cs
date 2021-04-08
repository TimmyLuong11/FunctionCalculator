using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaring Variables
            const string develperName = "Timmy Luong", className = "MIS3013", date = "April 3, 2021";
            DeveloperInformation(develperName, className, date);
            double num1, num2, num3, total;
            string answer = "";
            Console.SetWindowSize(130, 30);

            //Asking the user to input value to be calcualted and to see if they want to do a new calculation or use their previous answer
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

        /// <summary>
        /// Take the user answer and do the correct operation to the inputted values
        /// </summary>
        /// <param name="answer">A string representing the operation</param>
        /// <param name="num1">A double representing the first number</param>
        /// <param name="num2">A double representing the second number</param>
        /// <returns>
        /// This returns the total of the operation the user requested
        /// </returns>
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

        /// <summary>
        /// This validates that what the user enter was a number and not a string
        /// </summary>
        /// <param name="answer">A string representing the number to be validated</param>
        /// <returns>
        /// This returns the value that was enterd
        /// </returns>
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

        /// <summary>
        /// This does the addition operation the user requested
        /// </summary>
        /// <param name="val1">A double representing the first value</param>
        /// <param name="val2">A double representing the second value</param>
        /// <returns>
        /// Returns the result of the operation the user reqeusted
        /// </returns>
        static double Add(double val1, double val2)
        {
            return val1 + val2;
        }

        /// <summary>
        /// This does the subtraction operation the user requested
        /// </summary>
        /// <param name="val1">A double representing the first value</param>
        /// <param name="val2">A double representing the second value</param>
        /// <returns>
        /// Returns the result of the operation the user reqeusted
        /// </returns>
        static double Subtract(double val1, double val2)
        {
            return val1 - val2;
        }

        /// <summary>
        /// This does the multiplication operation the user requested
        /// </summary>
        /// <param name="val1">A double representing the first value</param>
        /// <param name="val2">A double representing the second value</param>
        /// <returns>
        /// Returns the result of the operation the user reqeusted
        /// </returns>
        static double Multiply(double val1, double val2)
        {
            return val1 * val2;
        }

        /// <summary>
        /// This does the division operation the user requested
        /// </summary>
        /// <param name="val1">A double representing the first value</param>
        /// <param name="val2">A double representing the second value</param>
        /// <returns>
        /// Returns the result of the operation the user reqeusted
        /// </returns>
        static double Divide(double val1, double val2)
        {
            return val1 / val2;
        }

        /// <summary>
        /// This output the developer information to the user
        /// </summary>
        /// <param name="developerName">A stirng representing the developer name</param>
        /// <param name="className">A string representing the class name</param>
        /// <param name="date">A string representing the date the program was written</param>
        static void DeveloperInformation(string developerName, string className, string date)
        {
            Console.WriteLine($"{developerName} wrote this program for {className} on {date}.\n");
        }
    }
}
