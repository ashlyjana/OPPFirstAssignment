using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ass1act8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out int number))
            {
                Console.WriteLine("Result after adding 10: " + (number + 10));
            }
            else
            {
                Console.WriteLine("Invalid input.");
            }





        }
    }
}
