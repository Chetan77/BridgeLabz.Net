using System;
using System.Collections.Generic;
using System.Text;

namespace MoodAnalyser.UseCase2
{
    class MoodWithExceptionHandling
    {
        public static string ReturningMoodByHandlingException(string message)
        {
            try
            {
                if (message.ToLower().Contains("sad"))
                {
                    return "SAD";
                }
                else if (message.ToLower().Contains("happy"))
                {
                    return "HAPPY";
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("");
                Console.WriteLine(e.StackTrace);
                return "HAPPY";
            }
            return null;
        }
    }
}
