using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ass1act27
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rows;
            int number = 1;

            Console.Write("Enter a number of rows: ");
            rows = int.Parse(Console.ReadLine());

            for (int i = 1; i <= rows; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(number + " ");
                    number++;
                }
                Console.WriteLine();
            }

        }
    }
}
