using System;

class Program
{
    static void Main()
    {
        // Display the purpose of the program to the user
        Console.WriteLine("=== GRADE CALCULATOR ===");
        Console.WriteLine("This program converts a numerical grade into a letter grade.");
        Console.WriteLine("Enter a grade between 0 and 100.");
        Console.WriteLine();

        // Ask the user to enter their numerical grade
        Console.Write("Enter your numerical grade: ");
        int grade = Convert.ToInt32(Console.ReadLine());

        // Determine the letter grade based on the value entered
        if (grade < 0 || grade > 100)
        {
            Console.WriteLine("Invalid grade. Please enter a value between 0 and 100.");
        }
        else if (grade >= 90)
        {
            Console.WriteLine("Your Letter Grade is: A");
        }
        else if (grade >= 80)
        {
            Console.WriteLine("Your Letter Grade is: B");
        }
        else if (grade >= 70)
        {
            Console.WriteLine("Your Letter Grade is: C");
        }
        else if (grade >= 60)
        {
            Console.WriteLine("Your Letter Grade is: D");
        }
        else
        {
            Console.WriteLine("Your Letter Grade is: F");
        }
    }
}