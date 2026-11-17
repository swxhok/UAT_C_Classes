using System;
using System.Collections.Generic;

namespace UAT_C_First_Class;

public static class UAT_ForEach_Class
{
    public static void Run()
    {
        Console.WriteLine("=== FOREACH LOOPS IN C# ===\n");

        // ==========================================
        // 1. FOREACH WITH AN ARRAY (Calculating Totals)
        // ==========================================
        Console.WriteLine("--- 1. Foreach with an Array ---");
        int[] examScores = { 85, 92, 78, 95, 88 };
        int totalScore = 0;

        foreach (int score in examScores)
        {
            Console.WriteLine($"Score: {score}");
            totalScore += score; // Adds each score to the running total
        }

        double average = (double)totalScore / examScores.Length;
        Console.WriteLine($"Total: {totalScore} | Average: {average}\n");


        // ==========================================
        // 2. FOREACH WITH A LIST<T>
        // ==========================================
        Console.WriteLine("--- 2. Foreach with a List ---");
        List<string> students = new List<string> { "Alice", "Bob", "Charlie", "Diana" };

        foreach (string student in students)
        {
            Console.WriteLine($"Welcome to class, {student}!");
        }
        Console.WriteLine();


        // ==========================================
        // 3. FOREACH OVER A STRING (Characters)
        // ==========================================
        Console.WriteLine("--- 3. Foreach over a String (char by char) ---");
        string word = "C# ROCKS";
        int vowelCount = 0;

        foreach (char letter in word)
        {
            Console.Write($"[{letter}] ");
            if ("AEIOUaeiou".Contains(letter))
            {
                vowelCount++;
            }
        }
        Console.WriteLine($"\nVowels found: {vowelCount}\n");


        // ==========================================
        // 4. FOREACH WITH A 2D ARRAY
        // ==========================================
        Console.WriteLine("--- 4. Foreach with a 2D Array ---");
        int[,] matrix = {
            { 10, 20 },
            { 30, 40 }
        };

        Console.Write("All elements in 2D grid: ");
        foreach (int number in matrix)
        {
            Console.Write($"{number} ");
        }
        Console.WriteLine("\n");


        // ==========================================
        // 5. FOREACH WITH BREAK & CONTINUE
        // ==========================================
        Console.WriteLine("--- 5. Controlling Foreach (continue & break) ---");
        string[] items = { "Coin", "Trap", "Gem", "Boss", "Treasure" };

        foreach (string item in items)
        {
            if (item == "Trap")
            {
                Console.WriteLine("Skipped the Trap! (continue)");
                continue; // Jumps to the next item
            }

            if (item == "Boss")
            {
                Console.WriteLine("Encountered the Boss! Stopping search. (break)");
                break; // Exits the loop completely
            }

            Console.WriteLine($"Collected: {item}");
        }
    }
}

