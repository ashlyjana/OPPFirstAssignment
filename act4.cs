using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ass1act4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;
            float celsius;

            Console.Write("Enter temperature in Celsius:");
            input = Console.ReadLine();
            bool isValid = float.TryParse(input, out celsius);

            if (!isValid || celsius < -100 || celsius > 100)
            {
                Console.WriteLine(" Invalid input.");
                Console.WriteLine(" Temperature must be anumber between -100 and 100.");
            }
            float fahreheit = (celsius * 9 / 5) + 32;
            Console.WriteLine($"Temperature in Fahrenheit: {fahreheit:F2}");

        }
    }
}
