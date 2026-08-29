using System;

class Program
{
    static void Main()
    {
        // Display the purpose and ticket pricing information
        Console.WriteLine("=== TICKET PRICE CALCULATOR ===");
        Console.WriteLine("This program calculates the movie ticket price based on age.");
        Console.WriteLine("Children aged 12 and below and senior citizens aged 65 and above pay GHC 7.");
        Console.WriteLine("All other customers pay GHC 10.");
        Console.WriteLine();

        // Ask the user to enter their age
        Console.Write("Enter your age: ");
        int age = Convert.ToInt32(Console.ReadLine());

        // Determine the ticket price based on age
        if (age < 0)
        {
            Console.WriteLine("Invalid age. Please enter a valid age.");
        }
        else if (age <= 12 || age >= 65)
        {
            Console.WriteLine("Your Ticket Price is: GHC 7");
        }
        else
        {
            Console.WriteLine("Your Ticket Price is: GHC 10");
        }
    }
}