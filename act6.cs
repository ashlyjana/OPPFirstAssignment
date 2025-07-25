using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        string input;
        string letter;

        Console.Write("Enter your grade (0–100): ");
         input = Console.ReadLine();

        if (int.TryParse(input, out int grade))
        {
            if (grade < 0 || grade > 100)
            {
                Console.WriteLine("Invalid grade. Must be between 0 and 100.");
                return;
            }
            if (grade >= 90)
                letter = "A";
            else if (grade >= 80)
                letter = "B";
            else if (grade >= 70)
                letter = "C";
            else if (grade >= 60)
                letter = "D";
            else
                letter = "F";

            Console.WriteLine($"Your grade is: {letter}");
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter an integer.");
        }
    }
}
