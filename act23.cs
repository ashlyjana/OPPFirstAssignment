using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ass1act23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a sentence: ");
            string sentence = Console.ReadLine();

            int upperCount = 0;

            foreach (char c in sentence)
            {
                if (char.IsUpper(c))
                {
                    upperCount++;
                }
            }

            Console.WriteLine("Uppercase letters: " + upperCount);
        }
    }
}
