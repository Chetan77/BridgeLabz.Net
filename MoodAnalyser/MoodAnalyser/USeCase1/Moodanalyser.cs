using System;
using System.Collections.Generic;
using System.Text;

namespace MoodAnalyser
{
    class Moodanalyser
    {
        string message;

        public Moodanalyser() { }

        public Moodanalyser(string message)
        {
            this.message = message;
        }
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
        public string AnalyseMoo()
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
