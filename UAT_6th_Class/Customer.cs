using System.Collections.Generic;

namespace UAT_C_First_Class;

// ==========================================
// LAB 6: CUSTOMER CLASS (Blueprint for Customer Objects)
// ==========================================
public class Customer
{
    // --- Auto-implemented Properties ---
    public string FirstName { get; set; }
    public string Surname { get; set; }
    public int Age { get; set; }

    // Challenge 1: Address stored as a dedicated Address object (nullable if not yet provided)
    public Address? Address { get; set; }

    // Challenge 2: Multiple savings accounts stored in a List<SavingsAccount>
    public List<SavingsAccount> SavingsAccounts { get; set; } = new List<SavingsAccount>();

    // Expression-bodied (read-only) property (as shown in Lesson 6 slides)
    public string FullName => $"{FirstName} {Surname}";

    // --- Constructors ---
    // Basic constructor setting FirstName, Surname, and Age
    public Customer(string firstName, string surname, int age)
    {
        FirstName = firstName;
        Surname = surname;
        Age = age;
    }

    // Overloaded constructor that also accepts an Address (reuses the basic constructor via ': this(...)')
    public Customer(string firstName, string surname, int age, Address address)
        : this(firstName, surname, age)
    {
        Address = address;
    }

    // --- Methods ---
    // Method to return the customer's full name
    public string GetFullName()
    {
        return $"{FirstName} {Surname}";
    }

    // Method to identify if the customer is 18 or over
    public bool Is18OrOver()
    {
        return Age >= 18;
    }

    // Challenge 2 helper: Add a savings account to this customer
    public void AddSavingsAccount(SavingsAccount account)
    {
        SavingsAccounts.Add(account);
    }

    // Challenge 2 helper: Calculate total balance across all savings accounts
    public decimal GetTotalSavingsBalance()
    {
        decimal total = 0m;

        foreach (SavingsAccount account in SavingsAccounts)
        {
            total += account.Balance;
        }

        return total;
    }
}

