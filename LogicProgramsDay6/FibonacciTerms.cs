using System;
using System.Collections.Generic;
using System.Text;

namespace LogicProgramsDay6
{
    public class FibonacciTerms
    {
        public static void IsFibo()
        {
            int num, a = 0, b = 1, c, i;
            Console.WriteLine("Enter The number of Terms Which you Want to Change as Fibonacci:");
            num = Int32.Parse(Console.ReadLine());
            for (i = 0; i <= num; i++)
            {
                if (i <= 1)
                    c = i;
                else
                {
                    c = a + b;
                    a = b;
                    b = c;
                }
                Console.WriteLine(c + "");


            }
            Console.ReadLine();

        }
    }
}
