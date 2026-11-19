using System;

namespace UAT_C_First_Class;

public static class UAT_6th_Class
{
    public static void Run()
    {
        Console.WriteLine("=== LESSON 6: METHODS, CLASSES & OBJECTS ===\n");

        // ==========================================
        // 1. METHODS (void, parameters, return values)
        // ==========================================
        Console.WriteLine("--- 1. Methods ---");

        // Directly calling a void method (performs an action, returns nothing)
        WriteHello();

        // Calling methods directly as input parameters to Console.WriteLine
        Console.WriteLine($"Add(10, 20) = {Add(10, 20)}");
        Console.WriteLine(GetGreetingToPerson("Tom"));

        // Assigning a method's return value to a variable
        int sumOfNumbers = AddNumbers(new int[] { 1, 2, 3, 4, 5 });
        Console.WriteLine($"Sum of [1, 2, 3, 4, 5] = {sumOfNumbers}");

        // Using a descriptive private helper method to improve readability & reusability
        double aer = CalculateAER(4.00, 12);
        Console.WriteLine($"AER for 4.00% compounded monthly (12x/yr): {aer:F2}%\n");


        // ==========================================
        // 2. CLASSES & OBJECTS (Lab 6 - Customer)
        // ==========================================
        Console.WriteLine("--- 2. Creating Objects from the Customer Class ---");

        // Creating an object using standard 'new Customer(...)' syntax
        Customer customer1 = new Customer("Tom", "Bates", 35);

        // Creating an object using simplified target-typed 'new(...)' syntax
        Customer customer2 = new("Danny", "Clarke", 17);

        // Accessing Properties and calling Methods on each object
        Console.WriteLine($"Customer 1: {customer1.GetFullName()} (Age: {customer1.Age}) | 18 or over? {customer1.Is18OrOver()}");
        Console.WriteLine($"Customer 2: {customer2.GetFullName()} (Age: {customer2.Age}) | 18 or over? {customer2.Is18OrOver()}");

        // Demonstrating the read-only expression-bodied property as well
        Console.WriteLine($"Read-only FullName property for Customer 1: {customer1.FullName}\n");


        // ==========================================
        // 3. CHALLENGE 1: CUSTOMER ADDRESS (Composition)
        // ==========================================
        Console.WriteLine("--- 3. Challenge 1: Customer Address ---");

        // Assign an Address object to an existing customer
        customer1.Address = new Address("42A", "High Street", "Skipton", "North Yorkshire", "BD23 1JX");

        // Or pass an Address object directly into the overloaded Customer constructor
        Address aliceAddress = new("10", "Oak Avenue", "Leeds", "West Yorkshire", "LS1 4AP");
        Customer customer3 = new Customer("Alice", "Walker", 29, aliceAddress);

        Console.WriteLine($"{customer1.GetFullName()}'s Address: {customer1.Address.FormattedAddress}");
        Console.WriteLine($"{customer3.GetFullName()}'s Address: {customer3.Address?.FormattedAddress}\n");


        // ==========================================
        // 4. CHALLENGE 2: CUSTOMER SAVINGS ACCOUNTS (List<SavingsAccount>)
        // ==========================================
        Console.WriteLine("--- 4. Challenge 2: Customer Savings Accounts ---");

        // Add multiple SavingsAccount objects to customer1
        SavingsAccount easyAccess = new SavingsAccount("SAV-1001", 1250.50m);
        SavingsAccount fixedRate = new("SAV-2045", 5000.00m);

        // Call a method on a SavingsAccount object to update its balance
        easyAccess.Deposit(249.50m);

        customer1.AddSavingsAccount(easyAccess);
        customer1.AddSavingsAccount(fixedRate);

        Console.WriteLine($"Savings Accounts for {customer1.GetFullName()} ({customer1.SavingsAccounts.Count} accounts):");
        foreach (SavingsAccount account in customer1.SavingsAccounts)
        {
            Console.WriteLine($"  - {account.GetSummary()}");
        }

        Console.WriteLine($"Total Savings Balance: £{customer1.GetTotalSavingsBalance():N2}");
    }

    // --- Example Methods from Lesson 6 ---

    // Public void method: performs an action and returns nothing
    public static void WriteHello()
    {
        Console.WriteLine("Hello");
    }

    // Public method taking two int parameters and returning their sum
    public static int Add(int number1, int number2)
    {
        return number1 + number2;
    }

    // Public method taking an array of ints and returning the total
    public static int AddNumbers(int[] numbers)
    {
        int totalOfNumbers = 0;

        foreach (int number in numbers)
        {
            totalOfNumbers = totalOfNumbers + number;
        }

        return totalOfNumbers;
    }

    // Public method taking a string parameter and returning a greeting string
    public static string GetGreetingToPerson(string name)
    {
        return "Hello " + name;
    }

    // Private method: only accessible inside this class (encapsulates a reusable calculation)
    private static double CalculateAER(double interestRate, int interestFrequency)
    {
        return (Math.Pow(1.0 + (interestRate / 100.0 / interestFrequency), interestFrequency) - 1.0) * 100;
    }
}

