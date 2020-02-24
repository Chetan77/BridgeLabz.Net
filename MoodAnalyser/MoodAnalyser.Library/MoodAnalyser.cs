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
            }
            catch (MoodAnalysisException)
            {
                throw new MoodAnalysisException(MoodAnalysisException.MoodList.Empty_Mood, "given mood is empty, please provide some mood");
                //return "HAPPY";
            }
            catch (NullReferenceException)
            {
                throw new MoodAnalysisException(MoodAnalysisException.MoodList.No_Mood, "given mood is null,please provide some mood");
            }
            return "HAPPY";
        }
    }
}
