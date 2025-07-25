using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ass1act28
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a word: ");
            string word = Console.ReadLine();

            string reversed = "";

            for (int i = word.Length - 1; i >= 0; i--)
            {
                reversed += word[i]; 
            }

            Console.WriteLine("Reversed word: " + reversed);

        }
    }
}
