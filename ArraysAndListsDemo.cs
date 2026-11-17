using System;
using System.Collections.Generic;

namespace UAT_C_First_Class
{
    public static class ArraysAndListsDemo
    {
        public static void Run()
        {
            // ==========================================
            // 1. ARRAYS IN C# (Fixed Size)
            // ==========================================
            Console.WriteLine("--- 1. Arrays (Fixed Size) ---");

            // A. Declaring an array with a fixed size of 3, then assigning values by index (0-based)
            int[] testScores = new int[3];
            testScores[0] = 88;
            testScores[1] = 92;
            testScores[2] = 95;

            // B. Declaring and initializing an array in one step
            string[] planets = { "Mercury", "Venus", "Earth", "Mars" };

            // Accessing and modifying elements via index
            Console.WriteLine($"First planet (index 0): {planets[0]}");
            Console.WriteLine($"Total planets in array (Length): {planets.Length}");

            // C. Sorting and reversing an Array
            Array.Sort(planets); // Sorts alphabetically: Earth, Mars, Mercury, Venus
            Console.WriteLine("Sorted planets: " + string.Join(", ", planets));

            // D. 2D (Multidimensional) Array - e.g., a 2x3 grid (2 rows, 3 columns)
            int[,] grid = {
                { 1, 2, 3 },
                { 4, 5, 6 }
            };
            Console.WriteLine($"Element at Row 1, Column 2: {grid[1, 2]}\n"); // Outputs 6


            // ==========================================
            // 2. LISTS IN C# (Dynamic Size)
            // ==========================================
            Console.WriteLine("--- 2. Lists (Dynamic / Resizable) ---");

            // A. Creating a List<T> and initializing it with values
            List<string> inventory = new List<string> { "Sword", "Shield" };

            // B. Adding elements dynamically (.Add and .Insert)
            inventory.Add("Health Potion");      // Adds to the end of the list
            inventory.Insert(1, "Bow");          // Inserts "Bow" at index 1 (shifts others right)

            Console.WriteLine($"Items in inventory (Count: {inventory.Count}): " + string.Join(", ", inventory));

            // C. Searching a List (.Contains and .IndexOf)
            bool hasShield = inventory.Contains("Shield");
            int potionIndex = inventory.IndexOf("Health Potion");
            Console.WriteLine($"Has Shield? {hasShield} | Health Potion is at index: {potionIndex}");

            // D. Removing elements (.Remove and .RemoveAt)
            inventory.Remove("Sword");           // Removes by value
            inventory.RemoveAt(0);               // Removes the item currently at index 0 ("Bow")

            Console.WriteLine("Updated inventory after removals: " + string.Join(", ", inventory));
        }
    }
}

