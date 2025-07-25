using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ass1act34
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number;

            Console.Write("Enter a positive integer: ");
            number = int.Parse(Console.ReadLine());

            while (number >= 10) // Repeat until the number becomes single-digit
            {
                int sum = 0;
                while (number > 0)
                {
                    sum += number % 10; // Add the last digit
                    number /= 10;       // Remove the last digit
                }
                number = sum; // Update number with the new sum
            }

            Console.WriteLine("Digital Root: " + number);
        }
    }
}
