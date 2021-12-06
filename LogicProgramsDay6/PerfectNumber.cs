using System;
using System.Collections.Generic;
using System.Text;

namespace LogicProgramsDay6
{
    class PerfectNumber
    {
        public static void isPerfect()
        {
            int sum = 0;
            int i = 1;
            int num;
            num = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= num; i++)
            {
                if (num % i == 0)
                    sum += i;
            }
            if (sum == i)
            {
                Console.WriteLine("It is a Perfect Number:" + num);
            }
            else
            {
                Console.WriteLine("Not a Perfect Number:" + num);
            }
            Console.ReadLine();
        }

        internal static void Equals()
        {
            throw new NotImplementedException();
        }
    }
}

