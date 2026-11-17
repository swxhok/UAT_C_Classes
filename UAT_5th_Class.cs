using System;

namespace UAT_C_First_Class;

public static class UAT_5th_Class
{
    public static void Run()
    {
        Console.WriteLine("=== LESSON 5: INPUTTING TEXT, PARSING & DEBUGGING ===\n");

        // ==========================================
        // 1. READING USER INPUT - Console.ReadLine()
        // ==========================================
        Console.WriteLine("--- 1. Reading User Input (Console.ReadLine) ---");
        Console.WriteLine("Hello");
        Console.Write("Enter your name: ");

        // Console.ReadLine() always reads user input in as a string
        string name = Console.ReadLine();

        Console.WriteLine("Your name is: " + name + "\n");


        // ==========================================
        // 2. PARSING (Converting String to Integer)
        // ==========================================
        // TIP FOR DEBUGGING: Click in the gray margin to the left of line 31 to set a
        // Breakpoint (red circle). When you run in Debug mode (F5), execution will pause here!
        Console.WriteLine("--- 2. Parsing Strings to Numbers (int.Parse) ---");
        Console.Write("Enter your age: ");

        string ageString = Console.ReadLine();
        int age = int.Parse(ageString); // Converts the string e.g. "55" into the integer 55

        Console.WriteLine("Your age is: " + age);
        Console.WriteLine($"Next year you will be: {age + 1}\n");


        // ==========================================
        // 3. OTHER PARSING EXAMPLES (bool, double, decimal)
        // ==========================================
        Console.WriteLine("--- 3. Parsing Other Data Types (bool, double, decimal) ---");

        string boolString = "true";
        bool aBool = bool.Parse(boolString);

        string doubleString = "3.14159";
        double aDouble = double.Parse(doubleString);

        string decimalString = "19.99";
        decimal aDecimal = decimal.Parse(decimalString);

        Console.WriteLine($"Parsed bool:    {aBool} (Type: {aBool.GetType().Name})");
        Console.WriteLine($"Parsed double:  {aDouble} (Type: {aDouble.GetType().Name})");
        Console.WriteLine($"Parsed decimal: {aDecimal} (Type: {aDecimal.GetType().Name})\n");


        // ==========================================
        // 4. EXCEPTIONS & DEBUGGING (System.FormatException)
        // ==========================================
        Console.WriteLine("--- 4. Exceptions & Debugging Demo ---");
        Console.WriteLine("What happens when you enter text (like 'Dan') when a number is expected?");
        Console.Write("Try entering a number (or type 'Dan' to see a FormatException): ");

        string testInput = Console.ReadLine();

        try
        {
            // Put a breakpoint here to step through and inspect 'testInput'!
            int parsedNumber = int.Parse(testInput);
            Console.WriteLine("Successfully parsed number: " + parsedNumber);
        }
        catch (FormatException ex)
        {
            // When int.Parse fails (e.g. input is "Dan"), C# throws System.FormatException
            Console.WriteLine($"\nBANG! Exception caught: {ex.GetType().FullName}");
            Console.WriteLine($"Message: '{ex.Message}'");
            Console.WriteLine("Tip: Remove the try/catch block or use Visual Studio's Exception Settings to pause directly on the crash line!");
        }
    }
}

