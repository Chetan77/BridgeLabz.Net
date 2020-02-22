using System;
using System.Collections.Generic;
using System.Text;

namespace MoodAnalyserLibrary
{
    public class MoodAnalyser
    {
        public static string AnalyseMood(string message)
        {
            if (message.ToLower().Contains("sad"))
            {
                Console.WriteLine("returning SAD");
                return "SAD";
            }
            else if (message.ToLower().Contains("happy"))
            {
                Console.WriteLine("returning HAPPY");
                return "HAPPY";
            }
            Console.WriteLine("returning HAPPY");
            return "HAPPY";
        }
    }
}
