using System;

namespace UAT_C_First_Class;

public static class UAT_7th_Class
{
    public static void Run()
    {
        Console.WriteLine("Welcome to the calculator");

        bool calculateAgain = true;

        // Loop until the user chooses not to calculate more numbers
        while (calculateAgain)
        {
            // 1. Get a valid calculation method ('+', '-', 'x', '/')
            string operation = ReadOperation();

            // 2. Get and parse the two numbers (Challenge 1: doubles, Challenge 2: try/catch validation)
            double number1 = ReadDouble("Enter your first number: ");
            double number2 = ReadDouble("Enter your second number: ");

            // 3. Create a Calculator object with the parsed numbers
            Calculator calculator = new Calculator(number1, number2);

            // 4. Call the matching Calculator method using an if / else if statement
            try
            {
                double result = 0;

                if (operation == "+")
                {
                    result = calculator.Add();
                }
                else if (operation == "-")
                {
                    result = calculator.Minus();
                }
                else if (operation == "x" || operation == "*")
                {
                    result = calculator.Multiply();
                }
                else if (operation == "/")
                {
                    result = calculator.Divide();
                }

                Console.WriteLine($"The result is {result}");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }

            Console.WriteLine("----");

            // 5. Ask if the user wants to run another calculation
            Console.Write("Do you want to calculate some more numbers? (y/n): ");
            string? answer = Console.ReadLine()?.Trim().ToLower();
            calculateAgain = (answer == "y" || answer == "yes");
        }
    }

    // Prompts for an operation until the user enters '+', '-', 'x', or '/'
    private static string ReadOperation()
    {
        while (true)
        {
            Console.Write("Enter your calculate method ('+','-','x','/'): ");
            string? input = Console.ReadLine()?.Trim().ToLower();

            if (input == "+" || input == "-" || input == "x" || input == "*" || input == "/")
            {
                return input;
            }

            Console.WriteLine("Invalid calculation method, please enter '+', '-', 'x', or '/'.");
        }
    }

    // Challenge 2: Validates numeric input using try/catch and loops until a valid double is entered
    private static double ReadDouble(string prompt)
    {
        while (true)
        {
            Console.Write(prompt);
            string? input = Console.ReadLine();

            try
            {
                if (input is null)
                {
                    throw new FormatException();
                }

                return double.Parse(input);
            }
            catch (FormatException)
            {
                Console.WriteLine("Your number is invalid try again!");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Your number is too large or too small, try again!");
            }
        }
    }
}

