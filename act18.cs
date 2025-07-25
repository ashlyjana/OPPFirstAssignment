using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ass1act18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;
            int number;

            Console.Write("Enter a positive number to start countdown: ");
            input = Console.ReadLine();
           

            bool isValid = int.TryParse(input, out number);
            if (!isValid || number <= 0)
            {
                Console.WriteLine("Invalid input. Please enter a positive integer.");
                return;
            }

            Console.WriteLine("\nCountdown: ");
            while (number >= 0)
            {
                Console.WriteLine(number);
                number--;
            }
        }
    }
}
