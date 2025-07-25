using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ass1act19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string secretWord = "open";
            string userGuess;
            do
            {
                Console.Write("Guess the secret word: ");
                userGuess = Console.ReadLine();
                if (!string.Equals(userGuess, secretWord, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("Try again.");
                }
            } while (!string.Equals(userGuess, secretWord, StringComparison.OrdinalIgnoreCase));
            Console.WriteLine("Correct!");
        }
    }
}
