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
            try
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
                else if (msg.Length == 0)
                {
                    throw new MoodAnalysisException(MoodAnalysisException.MoodList.Empty_Mood, "given mood is empty, please provide some mood");
                }
                else
                {
                    throw new MoodAnalysisException(MoodAnalysisException.MoodList.No_Such_Method, "no method found, enter proper method");
                }
                
            }
            //catch (MoodAnalysisException)
            //{
            //    throw new MoodAnalysisException(MoodAnalysisException.MoodList.Empty_Mood, "given mood is empty, please provide some mood");
            //    //return "HAPPY";
            //}
            
            catch (NullReferenceException)
            {
                throw new MoodAnalysisException(MoodAnalysisException.MoodList.No_Mood, "no mood, enter proper me");

            }
            return "HAPPY";
        }
        public override bool Equals(object obj)
        {
            object moodanalyser = MoodAnalyserFactory.CreateInstance("MoodAnalyser");
            if (moodanalyser.GetType(). Equals(obj.GetType()))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
