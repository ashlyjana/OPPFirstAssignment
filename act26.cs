using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ass1act26
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a sentence: ");
            string sentence = Console.ReadLine();

            int max = 0;       
            int count = 0;     

            for (int i = 0; i < sentence.Length; i++)
            {
                if (sentence[i] != ' ')
                {
                    count++;  
                }
                else
                {
                    if (count > max)
                        max = count;  

                    count = 0; 
                }
            }
            if (count > max)
                max = count;

            Console.WriteLine("Longest word length: " + max);
        }
    }
}
