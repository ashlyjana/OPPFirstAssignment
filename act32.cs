
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ass1act32
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a capital letter (A–Z): ");
            char endLetter = Console.ReadKey().KeyChar;
            Console.WriteLine();


            if (endLetter < 'A' || endLetter > 'Z')
            {
                Console.WriteLine("\nInvalid input. Please enter a capital letter from A to Z.");
                return;
            }


            for (char row = 'A'; row <= endLetter; row++)
            {

                for (char col = 'A'; col <= row; col++)
                {
                    Console.Write(col);
                }
                Console.WriteLine();
            }
        }
    }
}
