using System;
using System.Diagnostics;
using System.Threading;

namespace stopwatch_stimulate
{
    public class timer
    {
        static void Main(string [] args)
        {
            Stopwatch timer = new Stopwatch();
            timer.Start();
            Thread.Sleep(1000);
            timer.Stop();
            //get elapsed time as a timespan
            TimeSpan ts = timer.Elapsed;
            string end_time = string.Format(0, ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds / 10);
            Console.WriteLine()




        }
    }
}
