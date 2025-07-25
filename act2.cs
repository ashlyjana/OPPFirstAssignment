using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ass1act2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your age in years: ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out int age))
            {
                if (age >= 1 && age <= 120)
                {
                    int ageInMonths = age * 12;
                    Console.WriteLine($"You are {ageInMonths} months old.");
                }
                else
                {
                    Console.WriteLine("Error: Age must be between 1 and 120.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input.");
                Console.WriteLine("Please enter a valid number.");
            }
        }
    }
}
