using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ass1act29
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int start;
            int end;

            Console.Write("Enter start  number:");
            start = int.Parse(Console.ReadLine());
            Console.Write("Enter a end  number: ");
            end = int.Parse(Console.ReadLine());

            if (start >= end )
            {
                Console.WriteLine("Start need to be less than end");
                return;

            }
            Console.WriteLine("Prime numbers between " + start + "and" + end + ":");
            for ( int i = start; i <= end; i++ )
            {
                int count = 0;
                for (int j = 1; j <= i; j++)
                {
                    if (i % j == 0)
                    {
                        count++;
                    }
                }
                Console.WriteLine(i);
            }

        }
    }
}
