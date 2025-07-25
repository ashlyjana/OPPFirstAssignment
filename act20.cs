using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ass1act20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your password: ");
            string password = Console.ReadLine();

            bool hasNumber = false;
            bool hasUpper = false;

            // Check each character in the password
            foreach (char c in password)
            {
                if (char.IsDigit(c))
                {
                    hasNumber = true;
                }

                if (char.IsUpper(c))
                {
                    hasUpper = true;
                }
            }

            bool isValidLength = password.Length >= 8;

            if (isValidLength && hasNumber && hasUpper)
            {
                Console.WriteLine("Valid password");
            }
            else
            {
                Console.WriteLine("Invalid password. Issues:");
                if (!isValidLength)
                    Console.WriteLine("- Must be at least 8 characters long.");
                if (!hasNumber)
                    Console.WriteLine("- Must include at least one number.");
                if (!hasUpper)
                    Console.WriteLine("- Must include at least one uppercase letter.");
            }
        }
    }
}
