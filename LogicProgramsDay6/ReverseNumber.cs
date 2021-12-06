using System;
using System.Collections.Generic;
using System.Text;

namespace LogicProgramsDay6
{
    class ReverseNumber
    {
        public static void IsReverse()
        {
            int number;
            int rev = 0;
            number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter any number:number");
            Console.ReadLine();
            while (number > 0)
            {
                int rem = number % 10;
                rev = (rev * 10 + rem);
                number = number / 10;
            }
            Console.WriteLine("The Reverse Num is " + rev);
            Console.ReadLine();
        }

    }
}
