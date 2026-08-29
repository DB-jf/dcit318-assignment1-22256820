using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter your numerical grade (0 - 100): ");
        int grade = Convert.ToInt32(Console.ReadLine());

        if (grade < 0 || grade > 100)
        {
            Console.WriteLine("Invalid grade. Please enter a value between 0 and 100.");
        }
        else if (grade >= 90)
        {
            Console.WriteLine("Letter Grade: A");
        }
        else if (grade >= 80)
        {
            Console.WriteLine("Letter Grade: B");
        }
        else if (grade >= 70)
        {
            Console.WriteLine("Letter Grade: C");
        }
        else if (grade >= 60)
        {
            Console.WriteLine("Letter Grade: D");
        }
        else
        {
            Console.WriteLine("Letter Grade: F");
        }
    }
}