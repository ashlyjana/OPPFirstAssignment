using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ass1act25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int total = 0;

            while (true)
            {
                Console.Write("Enter number or 'stop': ");
                string input = Console.ReadLine();

                if (input.ToLower() == "stop")
                    break;

                if (int.TryParse(input, out int number))
                    total += number;
                else
                    Console.WriteLine("Please enter a number.");
            }

            Console.WriteLine("Total: " + total);
        }
    }
}
