using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Diagnostics;


namespace LogicProgramsDay6
{
    class StopWatch
    {
        public int Elapsed { get; private set; }

        public static void stopWatch()
        {
            StopWatch stopWatch = new StopWatch();
            StopWatch.Start();
            Console.WriteLine("Enter Number:");
            for (int i = 0; i <= 1000; i++)
            {
                Thread.Sleep(5);
            }
            StopWatch.Stop();
            Console.WriteLine("elapsed time:{0:hh\\:mm\\:ss}", stopWatch.Elapsed);
            Console.ReadKey();
        }

        private static void Stop()
        {
            throw new NotImplementedException();
            
        }

        private static void Start()
        {
            throw new NotImplementedException();
        }
    }
}

        
