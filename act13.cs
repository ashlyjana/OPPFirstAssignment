using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ass1act13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            if (!string.IsNullOrEmpty(name))
            {
                string formatted = char.ToUpper(name[0]) + name.Substring(1).ToLower();
                Console.WriteLine("Formatted name: " + formatted);
            }
            else
            {
                Console.WriteLine("Name cannot be empty.");
            }

        }
    }
}
