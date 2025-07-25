using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Lifetime;
using System.Text;
using System.Threading.Tasks;

namespace Ass1act33
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sentence;
            string choice;

            Console.Write("Enter a sentence: ");
            sentence = Console.ReadLine();

            Console.Write("Convert to (upper or lower): ");
            choice = Console.ReadLine().ToLower();

            string result = "";

            for (int i = 0; i < sentence.Length; i++)
            {
                char c = sentence[i];

                if (choice == "upper")
                {
                    if (c >= 'a' && c <= 'z')
                        result += (char)(c - 32);
                    else
                        result += c;
                }
                else if (choice == "lower")
                {
                    if (c >= 'A' && c <= 'Z')
                        result += (char)(c + 32);
                    else
                        result += c;
                }
                else
                {
                    Console.WriteLine("Invalid choice");
                    Console.WriteLine("Please enter 'upper' or 'lower'");
                    return;
                }
            }

            Console.WriteLine("Converted Sentence: " + result);
        }
    }
}
