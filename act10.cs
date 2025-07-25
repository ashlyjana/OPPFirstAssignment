using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ass1act10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name;
            string ageInput;
            string email;

            Console.Write("Enter your user name:");
            name = Console.ReadLine();

            Console.Write("Enter your age:");
            ageInput = Console.ReadLine();

            Console.Write("Enter your email:");
            email = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(name))
            {
                Console.WriteLine("Name is required.");
                return;
            }

            if (!int.TryParse(ageInput, out int age) || age < 1 || age > 120)
            {
                Console.WriteLine("Invalid age.");
                return;
            }

            if (string.IsNullOrWhiteSpace(email) || !email.Contains("@"))
            {
                Console.WriteLine("Invalid email.");
                return;
            }

            Console.WriteLine("All fields are valid.");

        }

    }
}
