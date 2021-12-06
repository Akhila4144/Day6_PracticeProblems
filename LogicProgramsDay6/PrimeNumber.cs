using System;
using System.Collections.Generic;
using System.Text;

namespace LogicProgramsDay6
{
    class PrimeNumber
    {
        public static void IsPrime()
        {
            int num;
            int i;
            Console.WriteLine("Enter a number:num");
            num = Convert.ToInt32(Console.ReadLine());
            for (i = 2; i <= num / 2; i++)
            {
                if (num % i == 0)
                {
                    Console.WriteLine("It is not a Prime" + num);
                }
                else
                {
                    Console.WriteLine("Is a Prime" + num);
                }
                Console.ReadLine();

            }
        }
    }
}
