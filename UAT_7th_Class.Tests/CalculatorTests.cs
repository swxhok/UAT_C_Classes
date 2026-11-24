using System;
using UAT_C_First_Class;

namespace UAT_7th_Class.Tests;

[TestClass]
public class CalculatorTests
{
    // ==========================================
    // 2. ADD TESTS (Data-Driven)
    // ==========================================
    [TestMethod]
    [TestCategory("Add")]
    [DataRow(3, 8, 11)]             // Positive integers
    [DataRow(-5, -3, -8)]           // Negative integers
    [DataRow(-5, 10, 5)]            // Negative and positive
    [DataRow(0, 7, 7)]              // Adding zero
    [DataRow(1.5, 2.25, 3.75)]      // Decimals
    public void Add_GivenTwoNumbers_ReturnsSum(double a, double b, double expected)
    {
        // Arrange
        Calculator calculator = new Calculator(a, b);

        // Act
        double result = calculator.Add();

        // Assert
        Assert.AreEqual(expected, result, 1e-9);
    }

    // ==========================================
    // 3. SUBTRACT (MINUS) TESTS (Data-Driven)
    // ==========================================
    [TestMethod]
    [TestCategory("Subtract")]
    [DataRow(10, 4, 6)]             // Larger minus smaller
    [DataRow(4, 10, -6)]            // Smaller minus larger (negative result)
    [DataRow(-5, -3, -2)]           // Subtracting a negative
    [DataRow(7, 0, 7)]              // Subtracting zero
    [DataRow(5.5, 2.2, 3.3)]        // Decimals
    public void Minus_GivenTwoNumbers_ReturnsDifference(double a, double b, double expected)
    {
        // Arrange
        Calculator calculator = new Calculator(a, b);

        // Act
        double result = calculator.Minus();

        // Assert
        Assert.AreEqual(expected, result, 1e-9);
    }

    // ==========================================
    // 4. MULTIPLY TESTS (Data-Driven)
    // ==========================================
    [TestMethod]
    [TestCategory("Multiply")]
    [DataRow(123, 654, 80442)]      // Positive integers
    [DataRow(5, 0, 0)]              // Multiplying by zero
    [DataRow(-4, 3, -12)]           // Negative times positive
    [DataRow(-4, -3, 12)]           // Negative times negative
    [DataRow(12.5, 2, 25)]          // Decimals
    public void Multiply_GivenTwoNumbers_ReturnsProduct(double a, double b, double expected)
    {
        // Arrange
        Calculator calculator = new Calculator(a, b);

        // Act
        double result = calculator.Multiply();

        // Assert
        Assert.AreEqual(expected, result, 1e-9);
    }

    // ==========================================
    // 5. DIVIDE TESTS (Data-Driven + Divide by Zero)
    // ==========================================
    [TestMethod]
    [TestCategory("Divide")]
    [DataRow(10, 2, 5)]             // Even division
    [DataRow(7, 2, 3.5)]            // Decimal quotient
    [DataRow(-10, 2, -5)]           // Negative dividend
    [DataRow(-10, -2, 5)]           // Negative dividend and divisor
    [DataRow(0, 5, 0)]              // Zero divided by non-zero
    public void Divide_GivenValidNumbers_ReturnsQuotient(double a, double b, double expected)
    {
        // Arrange
        Calculator calculator = new Calculator(a, b);

        // Act
        double result = calculator.Divide();

        // Assert
        Assert.AreEqual(expected, result, 1e-9);
    }

    [TestMethod]
    [TestCategory("Divide")]
    public void Divide_ByZero_ThrowsDivideByZeroException()
    {
        // Arrange
        Calculator calculator = new Calculator(10, 0);

        // Act & Assert
        Assert.ThrowsExactly<DivideByZeroException>(() => calculator.Divide());
    }

    // ==========================================
    // 6. POWER TESTS (Data-Driven)
    // ==========================================
    [TestMethod]
    [TestCategory("Power")]
    [DataRow(2, 3, 8)]              // Positive integer exponent
    [DataRow(5, 0, 1)]              // Any number to the power of 0
    [DataRow(7, 1, 7)]              // Exponent of 1
    [DataRow(2, -2, 0.25)]          // Negative exponent
    [DataRow(9, 0.5, 3)]            // Fractional exponent (square root)
    [DataRow(0, 3, 0)]              // Zero base with positive exponent
    public void Power_GivenBaseAndExponent_ReturnsResult(double a, double b, double expected)
    {
        // Arrange
        Calculator calculator = new Calculator(a, b);

        // Act
        double result = calculator.Power();

        // Assert
        Assert.AreEqual(expected, result, 1e-9);
    }
}

