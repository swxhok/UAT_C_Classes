using System;

namespace UAT_C_First_Class;

// ==========================================
// LAB 7: CALCULATOR CLASS
// ==========================================
// Challenge 1: Uses 'double' for Number1 and Number2 so both whole numbers and decimals are supported.
public class Calculator
{
    // --- Properties ---
    public double Number1 { get; set; }
    public double Number2 { get; set; }

    // --- Constructor ---
    public Calculator(double number1, double number2)
    {
        Number1 = number1;
        Number2 = number2;
    }

    // --- Methods ---
    public double Add()
    {
        return Number1 + Number2;
    }

    public double Minus()
    {
        return Number1 - Number2;
    }

    public double Multiply()
    {
        return Number1 * Number2;
    }

    public double Divide()
    {
        if (Number2 == 0)
        {
            throw new DivideByZeroException("Cannot divide by zero.");
        }

        return Number1 / Number2;
    }
}

