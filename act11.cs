using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ass1act11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string correctPin = "1234";
            int attempts = 0;
            string userPin;

            while (attempts < 3)
            {
                Console.Write("Enter your 4-digit PIN: ");
                userPin = Console.ReadLine();

                if (userPin == correctPin)
                {
                    Console.WriteLine("Access granted.");
                    return;
                }
                else
                {
                    attempts++;
                    if (attempts < 3)
                    {
                        Console.WriteLine("Incorrect PIN.");
                        Console.WriteLine("Try again!!!");
                    }
                }
            }

            Console.WriteLine("Access denied.");
        }
    }
}
