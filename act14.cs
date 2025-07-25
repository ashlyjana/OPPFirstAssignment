using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ass1act14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your age: ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out int age))
            {
                if (age >= 1 && age <= 130)
                {
                    if (age <= 12)
                        Console.WriteLine("Child");
                    else if (age <= 19)
                        Console.WriteLine("Teen");
                    else if (age <= 59)
                        Console.WriteLine("Adult");
                    else if ( age > 59)
                        Console.WriteLine("Senior");
                }
                else
                {
                    Console.WriteLine("Validate age to be between 1–130.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input.");
            }
        }
    }
}
