using System;

// ==========================================
// 1. VARIABLE TYPES IN C#
// ==========================================
Console.WriteLine("--- 1. Variable Types ---");

// Integer types (whole numbers)
int age = 25;
long population = 8000000000L;

// Floating-point types (decimals)
float temperature = 72.5f;         // 32-bit float (requires 'f' suffix)
double pi = 3.1415926535;          // 64-bit double-precision
decimal price = 19.99m;            // 128-bit high-precision for currency (requires 'm' suffix)

// Character and String types
char grade = 'A';                  // Single character (single quotes)
string name = "Alex";              // Text string (double quotes)

// Boolean type (true or false)
bool isEnrolled = true;

// Implicitly typed variable (compiler infers the type as 'string')
var course = "CSC101";

Console.WriteLine($"Name: {name}, Age: {age}, Grade: {grade}, Enrolled: {isEnrolled}");
Console.WriteLine($"Course: {course}, Price: ${price}, Temp: {temperature}°F, Pi: {pi}, Pop: {population}\n");


// ==========================================
// 2. TYPES OF OPERATORS IN C#
// ==========================================
Console.WriteLine("--- 2. Operators ---");

int a = 10;
int b = 3;

// A. Arithmetic Operators (+, -, *, /, %)
Console.WriteLine($"Addition (a + b): {a + b}");         // 13
Console.WriteLine($"Subtraction (a - b): {a - b}");      // 7
Console.WriteLine($"Multiplication (a * b): {a * b}");   // 30
Console.WriteLine($"Division (a / b): {a / b}");         // 3 (integer division truncates decimals)
Console.WriteLine($"Modulus/Remainder (a % b): {a % b}");// 1

// B. Assignment Operators (=, +=, -=, *=, /=)
int score = 10;
score += 5; // Same as: score = score + 5 (now 15)
score *= 2; // Same as: score = score * 2 (now 30)
Console.WriteLine($"Updated Score: {score}");

// C. Increment / Decrement Operators (++, --)
score++; // Adds 1 (now 31)
score--; // Subtracts 1 (now 30)

// D. Comparison (Relational) Operators (==, !=, >, <, >=, <=)
Console.WriteLine($"Is a equal to b? (a == b): {a == b}");         // False
Console.WriteLine($"Is a not equal to b? (a != b): {a != b}");     // True
Console.WriteLine($"Is a greater than b? (a > b): {a > b}");       // True

// E. Logical Operators (&&, ||, !)
bool hasTicket = true;
bool hasID = false;
Console.WriteLine($"AND (hasTicket && hasID): {hasTicket && hasID}"); // False (both must be true)
Console.WriteLine($"OR (hasTicket || hasID): {hasTicket || hasID}");  // True (at least one is true)
Console.WriteLine($"NOT (!hasTicket): {!hasTicket}");                 // False (inverts value)

// F. Ternary (Conditional) Operator (condition ? trueValue : falseValue)
string status = (age >= 18) ? "Adult" : "Minor";
Console.WriteLine($"Status: {status}\n");


// ==========================================
// 3. LOGIC (CONDITIONAL) STATEMENTS IN C#
// ==========================================
Console.WriteLine("--- 3. Logic Statements ---");

// A. if / else if / else statement
if (score >= 90)
{
    Console.WriteLine("if/else: Excellent score!");
}
else if (score >= 25)
{
    Console.WriteLine("if/else: Passing score!");
}
else
{
    Console.WriteLine("if/else: Needs improvement.");
}

// B. Classic switch statement
switch (grade)
{
    case 'A':
        Console.WriteLine("switch: Grade A - Outstanding!");
        break;
    case 'B':
    case 'C':
        Console.WriteLine("switch: Grade B or C - Good job!");
        break;
    default:
        Console.WriteLine("switch: Keep studying!");
        break;
}

// C. Modern switch expression (returns a value directly)
string feedback = grade switch
{
    'A' => "Top tier",
    'B' => "Above average",
    _   => "Standard" // '_' is the default discard pattern
};
Console.WriteLine($"switch expression: {feedback}\n");


// ==========================================
// 4. LOOP TYPES IN C#
// ==========================================
Console.WriteLine("--- 4. Loop Types ---");

// A. 'for' loop (best when you know the exact number of iterations)
Console.Write("for loop: ");
for (int i = 1; i <= 5; i++)
{
    Console.Write($"{i} ");
}
Console.WriteLine();

// B. 'foreach' loop (best for iterating through a collection/array)
string[] fruits = { "Apple", "Banana", "Cherry" };
Console.Write("foreach loop: ");
foreach (string fruit in fruits)
{
    Console.Write($"{fruit} ");
}
Console.WriteLine();

// C. 'while' loop (checks condition BEFORE running; may run 0 times)
Console.Write("while loop: ");
int count = 1;
while (count <= 3)
{
    Console.Write($"{count} ");
    count++;
}
Console.WriteLine();

// D. 'do-while' loop (runs block ONCE first, then checks condition)
Console.Write("do-while loop: ");
int attempts = 1;
do
{
    Console.Write($"Attempt #{attempts} ");
    attempts++;
} while (attempts <= 2);
Console.WriteLine();

// E. Loop control statements ('continue' and 'break')
Console.Write("break/continue in loop: ");
for (int n = 1; n <= 5; n++)
{
    if (n == 2) continue; // Skips the rest of iteration #2
    if (n == 4) break;    // Exits the loop completely at #4
    Console.Write($"{n} ");
}
Console.WriteLine("\n");
