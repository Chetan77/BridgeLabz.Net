using System;
using System.Collections.Generic;
using System.Text;

namespace MoodAnalyserLibrary
{
    public class MoodAnalyser
    {
        string msg;
       public MoodAnalyser()
        {

        }
       public MoodAnalyser(string msg)
        {
            this.msg = msg;
        }
        public string AnalyseMood()
        {
            if (msg.ToLower().Contains("sad"))
            {
                Console.WriteLine("returning SAD");
                return "SAD";
            }
            else if (msg.ToLower().Contains("happy"))
            {
                Console.WriteLine("returning HAPPY");
                return "HAPPY";
            }
            Console.WriteLine("returning HAPPY");
            return "HAPPY";
        }
    }
}
