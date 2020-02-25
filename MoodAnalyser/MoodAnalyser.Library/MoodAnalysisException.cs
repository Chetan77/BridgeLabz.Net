using System;
using System.Collections.Generic;
using System.Text;

namespace MoodAnalyserLibrary
{
    public class MoodAnalysisException :Exception
    {
        public enum MoodList
        {
            Empty_Mood,No_Mood,NoSuch_Class,No_Such_Method,No_Such_Class_With_Parameter
        }
        public string message;
        public MoodList moodList;

        public MoodAnalysisException(MoodList _moodList,string _message)
        {
            this.moodList = _moodList;
            this.message = _message;
        }
        public override string Message
        {
            get
            {
                return message;
            }
        }
    }
}
