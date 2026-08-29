using System;

class Program
{
    static void Main()
    {
        // Display the purpose of the program
        Console.WriteLine("=== TRIANGLE TYPE IDENTIFIER ===");
        Console.WriteLine("This program identifies a triangle based on the lengths of its three sides.");
        Console.WriteLine("Enter the length of each side when prompted.");
        Console.WriteLine();

        // Ask the user to enter the three sides
        Console.Write("Enter the first side: ");
        double side1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the second side: ");
        double side2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the third side: ");
        double side3 = Convert.ToDouble(Console.ReadLine());

        // Check that all sides contain positive values
        if (side1 <= 0 || side2 <= 0 || side3 <= 0)
        {
            Console.WriteLine("Invalid input. Triangle sides must be greater than zero.");
        }
        // All three sides are equal
        else if (side1 == side2 && side2 == side3)
        {
            Console.WriteLine("Triangle Type: Equilateral");
            Console.WriteLine("All three sides are equal.");
        }
        // Any two sides are equal
        else if (side1 == side2 || side1 == side3 || side2 == side3)
        {
            Console.WriteLine("Triangle Type: Isosceles");
            Console.WriteLine("Two sides of the triangle are equal.");
        }
        // None of the sides are equal
        else
        {
            Console.WriteLine("Triangle Type: Scalene");
            Console.WriteLine("All three sides have different lengths.");
        }
    }
}