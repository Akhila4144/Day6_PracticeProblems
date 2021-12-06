using System;
using System.Collections.Generic;
using System.Text;

namespace LogicProgramsDay6
{
    class CouponNumbers
    {
        public void coupons(int n)//n=5
        {
            Random ran = new Random();
            int check = ran.Next(0, 9);
            int count = 0;
            Console.WriteLine("Coupon number is: " + n);
            while (n > 0)
            {
                if (check == n)
                {
                    Console.WriteLine("number is present");
                }
                count++;
                Console.WriteLine("count:" + count);
                n--;
            }
            Console.WriteLine("to get number we need count" + count);

        }
    }
}

