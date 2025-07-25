using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ass1act7

internal class Program
{
    static void Main(string[]args)
    {
        float num1;
        string op;
        float num2;
        

        Console.Write("Enter first number: ");
        num1 = float.Parse(Console.ReadLine());

        Console.Write("Enter operator (+, -, *, /): ");
        op = Console.ReadLine();

        Console.Write("Enter second number: ");
        num2 = float.Parse(Console.ReadLine());

        

        switch (op)
        {
            case "+":
                Console.WriteLine($"The result is: {num1 + num2}");
                break;

            case "-":
                Console.WriteLine($"The result is: {num1 - num2}");
                break;

            case "*":
                Console.WriteLine($"The result is: {num1 * num2}");
                break;

            case "/":
                if (num2 != 0)
                    Console.WriteLine($"The result is: {num1 / num2}");
                else
                    Console.WriteLine("Cannot divide by zero.");
                break;

            default:
                Console.WriteLine("Invalid operator.");
                break;
        }
    }
}
