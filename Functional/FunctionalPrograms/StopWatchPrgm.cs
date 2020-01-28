using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;
using System.Threading;

namespace FunctionalPrograms
{
    class StopWatchPrgm
    {
        public static void StopwatchElapsedTime()
        {
            try {
                Stopwatch stopWatch = new Stopwatch();
                stopWatch.Start();
                Console.WriteLine("enter number to calculate ");
                int a = Utility.IntInput();
            stopWatch.Stop();
            TimeSpan ts = stopWatch.Elapsed;
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}:{3:00}",
                ts.Hours, ts.Minutes, ts.Seconds,
                ts.Milliseconds / 10);
            Console.WriteLine("RunTime " + elapsedTime);
            }
            catch
            {
                Console.WriteLine("");
            }
        }
    }
}
