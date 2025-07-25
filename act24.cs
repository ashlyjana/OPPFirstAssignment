using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ass1act24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string correctUsername = "admin";
            string correctPassword = "1234";
            string username, password;

            do
            {
                Console.Write("Enter username: ");
                username = Console.ReadLine();

                Console.Write("Enter password: ");
                password = Console.ReadLine();

                if (username == correctUsername && password == correctPassword)
                {
                    Console.WriteLine("Login successful");
                }
                else
                {
                    Console.WriteLine("Try again");
                }

            } while (username != correctUsername || password != correctPassword);
        }
    }
}
